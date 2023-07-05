namespace PhoneDirectory
{
    partial class PDirectory
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnKapat = new Button();
            btnLogin = new Button();
            lblInfo = new Label();
            lblStick = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(206, 66);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(129, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(206, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(129, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(80, 66);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 129);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnKapat
            // 
            btnKapat.Location = new Point(80, 185);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(108, 41);
            btnKapat.TabIndex = 4;
            btnKapat.Text = "Close";
            btnKapat.UseVisualStyleBackColor = true;
            btnKapat.Click += btnKapat_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(206, 185);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.Location = new Point(12, 254);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(384, 45);
            lblInfo.TabIndex = 6;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStick
            // 
            lblStick.BackColor = Color.CornflowerBlue;
            lblStick.BorderStyle = BorderStyle.FixedSingle;
            lblStick.Location = new Point(2, 1);
            lblStick.Name = "lblStick";
            lblStick.Size = new Size(406, 41);
            lblStick.TabIndex = 7;
            lblStick.TextAlign = ContentAlignment.MiddleCenter;
            lblStick.MouseDown += lblStick_MouseDown;
            lblStick.MouseMove += lblStick_MouseMove;
            lblStick.MouseUp += lblStick_MouseUp;
            // 
            // PDirectory
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(408, 308);
            Controls.Add(lblStick);
            Controls.Add(lblInfo);
            Controls.Add(btnLogin);
            Controls.Add(btnKapat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PDirectory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDirectory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Button btnKapat;
        private Button btnLogin;
        private Label lblInfo;
        private Label lblStick;
    }
}