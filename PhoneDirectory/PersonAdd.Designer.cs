namespace PhoneDirectory
{
    partial class PersonAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            label2 = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtMail = new TextBox();
            lblEmail = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Location = new Point(47, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 33);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(133, 23);
            txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(172, 117);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(133, 23);
            txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(47, 108);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(172, 177);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(133, 23);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.BorderStyle = BorderStyle.FixedSingle;
            lblPhone.Location = new Point(47, 168);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 32);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(172, 232);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(133, 23);
            txtMail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.BorderStyle = BorderStyle.FixedSingle;
            lblEmail.Location = new Point(47, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 31);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(47, 298);
            button1.Name = "button1";
            button1.Size = new Size(258, 61);
            button1.TabIndex = 8;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PersonAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 450);
            Controls.Add(button1);
            Controls.Add(txtMail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "PersonAdd";
            Text = "PersonAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label2;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtMail;
        private Label lblEmail;
        private Button button1;
    }
}