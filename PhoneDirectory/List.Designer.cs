namespace PhoneDirectory
{
    partial class List
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSignout = new Button();
            lblInfo = new Label();
            dataGridView1 = new DataGridView();
            Names = new DataGridViewTextBoxColumn();
            Surnames = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(708, 380);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(btnSignout, 4, 0);
            tableLayoutPanel2.Controls.Add(lblInfo, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 283);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(702, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Gold;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 88);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(192, 192, 255);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Gold;
            btnEdit.Location = new Point(123, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 88);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 192, 255);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Gold;
            btnDelete.Location = new Point(243, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 88);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSignout
            // 
            btnSignout.BackColor = Color.FromArgb(192, 192, 255);
            btnSignout.Dock = DockStyle.Fill;
            btnSignout.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignout.ForeColor = Color.Gold;
            btnSignout.Location = new Point(585, 3);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(114, 88);
            btnSignout.TabIndex = 3;
            btnSignout.Text = "SIGN OUT";
            btnSignout.UseVisualStyleBackColor = false;
            btnSignout.Click += btnSignout_Click;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Location = new Point(363, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(216, 94);
            lblInfo.TabIndex = 4;
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Names, Surnames, Phone, Mail, Column1 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(702, 274);
            dataGridView1.TabIndex = 1;
            // 
            // Names
            // 
            Names.DataPropertyName = "Name";
            Names.HeaderText = "Name";
            Names.Name = "Names";
            Names.ReadOnly = true;
            // 
            // Surnames
            // 
            Surnames.DataPropertyName = "Surname";
            Surnames.HeaderText = "Surname";
            Surnames.Name = "Surnames";
            Surnames.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone Number";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Email";
            Mail.HeaderText = "E-Mail";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Date";
            Column1.HeaderText = "Date of Registration";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 380);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "List";
            Text = "List";
            WindowState = FormWindowState.Maximized;
            Activated += List_Activated;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSignout;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Names;
        private DataGridViewTextBoxColumn Surnames;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewTextBoxColumn Column1;
        private Label lblInfo;
    }
}