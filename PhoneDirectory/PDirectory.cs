using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory
{
    public partial class PDirectory : Form
    {
        bool isDragging = false;
        Point lastLocation;
        public PDirectory()
        {
            InitializeComponent();

        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            PhoneDirectoryEntities db = new PhoneDirectoryEntities();
            var user = db.user.FirstOrDefault(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Status);

            if (user != null)
            {
                Program.user = user;
                List liste = new List();
                liste.Show();
                this.Hide();
            }
            else
            {
                lblInfo.Text = "Kullanıcı adı veya parola bilgisi hatalı";
                lblInfo.ForeColor = Color.Yellow;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStick_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void lblStick_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    this.Location.X + (e.X - lastLocation.X),
                    this.Location.Y + (e.Y - lastLocation.Y)
                    );
            }
        }

        private void lblStick_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
