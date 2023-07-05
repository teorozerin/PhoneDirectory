using PhoneDirectory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class PersonAdd : Form
    {
        public PersonAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text.Trim();
            person.Surname = txtSurname.Text.Trim();
            person.Phone = txtPhone.Text.Trim();
            person.Email=txtMail.Text.Trim();
            person.Date=DateTime.Now;
            person.Status = true;
            person.UserId = Program.user.Id;

            if (string.IsNullOrEmpty(person.Name) || string.IsNullOrEmpty(person.Surname) || string.IsNullOrEmpty(person.Phone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""))) 
            {
                MessageBox.Show("Kayıt işlemi tamamlanamadı\nTüm alanları doldurduğunuzdan emin olun", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    PhoneDirectoryEntities db = new PhoneDirectoryEntities();
                    db.person.Add(person);
                    db.SaveChanges();
                    MessageBox.Show(string.Format("{0} {1} kişisi başarı ile kayıt edildi", person.Name, person.Surname), "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
