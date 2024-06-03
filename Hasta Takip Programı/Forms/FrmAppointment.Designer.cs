namespace Hasta_Takip_Programı.Forms
{
    partial class FrmAppointment
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
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label8 = new Label();
            txtVisitReason = new TextBox();
            txtDoctorId = new TextBox();
            txtPatientId = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgAppointment = new DataGridView();
            dgDoctor = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            txtProfession = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLastName = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtBirthday = new TextBox();
            label16 = new Label();
            txtAddress = new TextBox();
            txtGender = new TextBox();
            label17 = new Label();
            label18 = new Label();
            dgPatient = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            dtAppointmentDate = new DateTimePicker();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(366, 8);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(79, 34);
            btnClear.TabIndex = 37;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(202, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 34);
            btnUpdate.TabIndex = 36;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(285, 8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 34);
            btnDelete.TabIndex = 35;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(121, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 34);
            btnSave.TabIndex = 34;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(561, 116);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 33;
            label8.Text = "Ziyaret Nedeni";
            // 
            // txtVisitReason
            // 
            txtVisitReason.Location = new Point(651, 113);
            txtVisitReason.Name = "txtVisitReason";
            txtVisitReason.Size = new Size(92, 23);
            txtVisitReason.TabIndex = 32;
            // 
            // txtDoctorId
            // 
            txtDoctorId.Location = new Point(651, 169);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(92, 23);
            txtDoctorId.TabIndex = 30;
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(651, 140);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(92, 23);
            txtPatientId.TabIndex = 29;
            // 
            // txtId
            // 
            txtId.Location = new Point(652, 57);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(92, 23);
            txtId.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(22, 10);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 27;
            label7.Text = "Randevu ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 88);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 25;
            label4.Text = "Randevu Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(583, 172);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 24;
            label3.Text = "Doktor No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 143);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 23;
            label2.Text = "Hasta No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(562, 60);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 22;
            label1.Text = "Randevu No";
            // 
            // dgAppointment
            // 
            dgAppointment.AllowUserToAddRows = false;
            dgAppointment.AllowUserToDeleteRows = false;
            dgAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAppointment.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column8, Column4, Column6 });
            dgAppointment.Location = new Point(12, 47);
            dgAppointment.Name = "dgAppointment";
            dgAppointment.ReadOnly = true;
            dgAppointment.RowTemplate.Height = 25;
            dgAppointment.Size = new Size(516, 155);
            dgAppointment.TabIndex = 21;
            dgAppointment.CellClick += dgAppointment_CellClick;
            // 
            // dgDoctor
            // 
            dgDoctor.AllowUserToAddRows = false;
            dgDoctor.AllowUserToDeleteRows = false;
            dgDoctor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDoctor.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column2, Column3, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgDoctor.Location = new Point(12, 208);
            dgDoctor.Name = "dgDoctor";
            dgDoctor.ReadOnly = true;
            dgDoctor.RowTemplate.Height = 25;
            dgDoctor.Size = new Size(516, 155);
            dgDoctor.TabIndex = 67;
            dgDoctor.CellClick += dgDoctor_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn1.HeaderText = "Doktor No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 87;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column3.HeaderText = "Soyadı";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn2.HeaderText = "Uzmanlık Alanı";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 111;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn3.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 72;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn4.HeaderText = "Telefon No";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 89;
            // 
            // txtProfession
            // 
            txtProfession.Location = new Point(651, 355);
            txtProfession.Name = "txtProfession";
            txtProfession.ReadOnly = true;
            txtProfession.Size = new Size(92, 23);
            txtProfession.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 329);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 65;
            label5.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(651, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(92, 23);
            txtEmail.TabIndex = 64;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(651, 297);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(92, 23);
            txtPhoneNumber.TabIndex = 63;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(651, 268);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(92, 23);
            txtLastName.TabIndex = 62;
            // 
            // txtName
            // 
            txtName.Location = new Point(651, 239);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(92, 23);
            txtName.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(583, 300);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 59;
            label9.Text = "Telefon No ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(558, 358);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 58;
            label10.Text = "Uzmanlık Alanı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(603, 271);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 57;
            label11.Text = "Soyadı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(619, 244);
            label12.Name = "label12";
            label12.Size = new Size(25, 15);
            label12.TabIndex = 56;
            label12.Text = "Adı";
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(651, 465);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.ReadOnly = true;
            txtBirthday.Size = new Size(92, 23);
            txtBirthday.TabIndex = 83;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(593, 440);
            label16.Name = "label16";
            label16.Size = new Size(37, 15);
            label16.TabIndex = 78;
            label16.Text = "Adres";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(652, 432);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(92, 23);
            txtAddress.TabIndex = 77;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(651, 403);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(92, 23);
            txtGender.TabIndex = 76;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(593, 410);
            label17.Name = "label17";
            label17.Size = new Size(49, 15);
            label17.TabIndex = 72;
            label17.Text = "Cinsiyet";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(595, 468);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 71;
            label18.Text = "Doğum";
            // 
            // dgPatient
            // 
            dgPatient.AllowUserToAddRows = false;
            dgPatient.AllowUserToDeleteRows = false;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPatient.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dgPatient.Location = new Point(12, 369);
            dgPatient.Name = "dgPatient";
            dgPatient.ReadOnly = true;
            dgPatient.RowTemplate.Height = 25;
            dgPatient.Size = new Size(516, 124);
            dgPatient.TabIndex = 84;
            dgPatient.CellClick += dgPatient_CellClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn5.HeaderText = "Hasta Kimliği";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 102;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn6.HeaderText = "Ad";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 47;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn7.HeaderText = "Soyadı";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 67;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn8.HeaderText = "Doğum";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 72;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn9.HeaderText = "Cinsiyet";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 74;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn10.HeaderText = "Adres";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 62;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn11.HeaderText = "Telefon No";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 89;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn12.HeaderText = "E-Posta";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 72;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(451, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(79, 34);
            btnSearch.TabIndex = 85;
            btnSearch.Text = "Gözat";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtAppointmentDate
            // 
            dtAppointmentDate.Location = new Point(652, 88);
            dtAppointmentDate.Name = "dtAppointmentDate";
            dtAppointmentDate.Size = new Size(200, 23);
            dtAppointmentDate.TabIndex = 86;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Randevu No";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 97;
            // 
            // Column7
            // 
            Column7.HeaderText = "Hasta No";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Doktor No";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column4.HeaderText = "Randevu Tarihi";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 109;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column6.HeaderText = "Ziyaret Nedeni";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 109;
            // 
            // FrmAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1332, 658);
            Controls.Add(dtAppointmentDate);
            Controls.Add(btnSearch);
            Controls.Add(dgPatient);
            Controls.Add(txtBirthday);
            Controls.Add(label16);
            Controls.Add(txtAddress);
            Controls.Add(txtGender);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(dgDoctor);
            Controls.Add(txtProfession);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(txtVisitReason);
            Controls.Add(txtDoctorId);
            Controls.Add(txtPatientId);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgAppointment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAppointment";
            Text = "FrmAppointment";
            Load += FrmAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgAppointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Label label8;
        private TextBox txtVisitReason;
        private TextBox txtDoctorId;
        private TextBox txtPatientId;
        private TextBox txtId;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgAppointment;
        private DataGridView dgDoctor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private TextBox txtProfession;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtBirthday;
        private Label label16;
        private TextBox txtAddress;
        private TextBox txtGender;
        private Label label17;
        private Label label18;
        private DataGridView dgPatient;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Button btnSearch;
        private DateTimePicker dtAppointmentDate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
    }
}