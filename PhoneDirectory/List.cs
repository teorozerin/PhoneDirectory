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
    public partial class List : Form
    {
        string value = string.Empty;
        int activeId = 0;
        public List()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void List_Activated(object sender, EventArgs e)
        {
            PersonList();
        }

        private void PersonList()
        {
            PhoneDirectoryEntities db = new PhoneDirectoryEntities();
            var user = db.person.Where(x => x.UserId == Program.user.Id && x.Status).ToList();
            dataGridView1.DataSource = user;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Oturumunuzu Kapatmak İstediğinize Emin Misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                PDirectory pd = new PDirectory();
                pd.Show();
                this.Hide();
                Program.user = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (activeId == 0)
            {
                lblInfo.Text = "Düzenlenecek kişi seçilmedi";
                lblInfo.ForeColor = Color.Red;
            }
            else
            {
                PersonEdit edit = new PersonEdit(activeId);
                edit.ShowDialog();
            }
            //PersonAdd person = new PersonAdd();
            //person.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int activeIndex = e.RowIndex;

            try
            {
                value = dataGridView1.Rows[activeIndex].Cells["Id"].Value.ToString();
                activeId = int.Parse(value);
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PhoneDirectoryEntities db = new PhoneDirectoryEntities();
            if (activeId == 0)
            {
                lblInfo.Text = "Silinecek kişi seçilmedi";
                lblInfo.ForeColor = Color.Red;
            }
            else
            {
                DialogResult dlg = MessageBox.Show("Kişi silme işlemi yapmak istediğinize emin misiniz", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    var person = db.person.Find(activeId);
                    if (person != null)
                    {
                        try
                        {
                            string delete = person.Name + " " + person.Surname;
                            person.Status = false;
                            db.SaveChanges();

                            lblInfo.Text = string.Format("{0} kişisi başarı ile silindi", delete);
                            PersonList();
                        }
                        catch (Exception)
                        {
                            lblInfo.Text = "Silme işlemi esnasında bir hata meydana geldi";
                            lblInfo.ForeColor = Color.Red;

                        }
                    }
                }
                else
                {
                    activeId = 0;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonAdd person = new PersonAdd();
            person.ShowDialog();
        }
    }
}
