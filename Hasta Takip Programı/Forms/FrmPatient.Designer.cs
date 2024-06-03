namespace Hasta_Takip_Programı.Forms
{
    partial class FrmPatient
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
            label7 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtAddress = new TextBox();
            txtGender = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label1 = new Label();
            dgPatient = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            txtBirthday = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 369);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 61;
            label7.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(384, 361);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(92, 23);
            txtEmail.TabIndex = 60;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(384, 332);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(92, 23);
            txtPhoneNumber.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(291, 337);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 58;
            label9.Text = "Telefon No ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 307);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 56;
            label8.Text = "Adres";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(384, 299);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(92, 23);
            txtAddress.TabIndex = 55;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(124, 419);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(92, 23);
            txtGender.TabIndex = 54;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(124, 358);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(92, 23);
            txtLastName.TabIndex = 53;
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 329);
            txtName.Name = "txtName";
            txtName.Size = new Size(92, 23);
            txtName.TabIndex = 52;
            // 
            // txtId
            // 
            txtId.Location = new Point(124, 300);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(92, 23);
            txtId.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 419);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 50;
            label6.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 396);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 49;
            label4.Text = "Doğum";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 361);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 48;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 332);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 47;
            label2.Text = "Ad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 302);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 46;
            label5.Text = "Hasta Kimliği\r\n";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(578, 342);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(79, 34);
            btnClear.TabIndex = 45;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(578, 300);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 34);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(497, 342);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 34);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(497, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 34);
            btnSave.TabIndex = 42;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 41;
            label1.Text = "Hasta";
            // 
            // dgPatient
            // 
            dgPatient.AllowUserToAddRows = false;
            dgPatient.AllowUserToDeleteRows = false;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPatient.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgPatient.Location = new Point(28, 40);
            dgPatient.Name = "dgPatient";
            dgPatient.ReadOnly = true;
            dgPatient.RowTemplate.Height = 25;
            dgPatient.Size = new Size(629, 251);
            dgPatient.TabIndex = 40;
            dgPatient.CellClick += dgPatient_CellClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Hasta Kimliği";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 102;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Ad";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 47;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Soyadı";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 67;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "Doğum";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 72;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column5.HeaderText = "Cinsiyet";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 74;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.HeaderText = "Adres";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 62;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column7.HeaderText = "Telefon No";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 89;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column8.HeaderText = "E-Posta";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 72;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(124, 390);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(92, 23);
            txtBirthday.TabIndex = 62;
            // 
            // FrmPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(705, 474);
            Controls.Add(txtBirthday);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(dgPatient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPatient";
            Text = "FrmPatient";
            Load += FrmPatient_Load;
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label9;
        private Label label8;
        private TextBox txtAddress;
        private TextBox txtGender;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtId;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Label label1;
        private DataGridView dgPatient;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox txtBirthday;
    }
}