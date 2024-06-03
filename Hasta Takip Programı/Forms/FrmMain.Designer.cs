namespace Hasta_Takip_Programı
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new Button();
            btnPatient = new Button();
            btnDoctor = new Button();
            btnAppointment = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnPatient);
            panel1.Controls.Add(btnDoctor);
            panel1.Controls.Add(btnAppointment);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 547);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(32, 239);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 37);
            btnExit.TabIndex = 14;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPatient
            // 
            btnPatient.FlatStyle = FlatStyle.Flat;
            btnPatient.Location = new Point(32, 153);
            btnPatient.Name = "btnPatient";
            btnPatient.Size = new Size(127, 37);
            btnPatient.TabIndex = 13;
            btnPatient.Text = "Hasta";
            btnPatient.UseVisualStyleBackColor = true;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Location = new Point(32, 110);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(127, 37);
            btnDoctor.TabIndex = 12;
            btnDoctor.Text = "Doktor";
            btnDoctor.UseVisualStyleBackColor = true;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btnAppointment
            // 
            btnAppointment.FlatStyle = FlatStyle.Flat;
            btnAppointment.Location = new Point(32, 196);
            btnAppointment.Name = "btnAppointment";
            btnAppointment.Size = new Size(127, 37);
            btnAppointment.TabIndex = 11;
            btnAppointment.Text = "Randevu";
            btnAppointment.UseVisualStyleBackColor = true;
            btnAppointment.Click += btnAppointment_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(179, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 103);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(291, 37);
            label2.TabIndex = 9;
            label2.Text = "Hasta Takip Programı";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(179, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(702, 444);
            panel3.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(881, 547);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnExit;
        private Button btnPatient;
        private Button btnDoctor;
        private Button btnAppointment;
        private Label label2;
        private Panel panel3;
    }
}
