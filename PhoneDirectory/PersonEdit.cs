using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class PersonEdit : Form
    {
        PhoneDirectoryEntities db = null;
        int _personId;
        public PersonEdit(int personId)
        {
            _personId = personId;
            db = new PhoneDirectoryEntities();
            InitializeComponent();

            var person = db.person.Find(personId);
            if (person != null )
            {
                txtName.Text = person.Name;
                txtSurname.Text = person.Surname;
                txtPhone.Text = person.Phone;
                txtMail.Text = person.Email;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            db = new PhoneDirectoryEntities();
            var dPerson = db.person.Find(_personId);
            if( dPerson != null )
            {
                dPerson.Name = txtName.Text.Trim();
                dPerson.Surname = txtSurname.Text.Trim();
                dPerson.Phone = txtPhone.Text.Trim();
                dPerson.Email = txtMail.Text.Trim() ;

                if (string.IsNullOrEmpty(dPerson.Name) || string.IsNullOrEmpty(dPerson.Surname) || string.IsNullOrEmpty(dPerson.Phone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
                {
                    MessageBox.Show("Düzenleme işlemi tamamlanamadı\nTüm alanları doldurduğunuzdan emin olun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Düzenleme işlemi başarı ile tamamlandı", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Düzenleme işlemi esnasında bir hata meydana geldi", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
