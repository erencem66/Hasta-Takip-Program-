using Hasta_Takip_Programı.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasta_Takip_Programı.Forms
{
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            GetPatientList();
        }
        void GetPatientList()
        {
            dgPatient.Rows.Clear();
            List<Patient> patients = db.Patients.ToList();
            foreach (var patient in patients)
            {
                dgPatient.Rows.Add(patient.Id, patient.Name, patient.LastName, patient.Birthday, patient.Gender, patient.Address, patient.PhoneNumber, patient.Email);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtGender.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var patientid = Convert.ToInt32(txtId.Text);
            var patient = db.Patients.Where(x => x.Id == patientid).SingleOrDefault();
            if (patientid == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //patient.Id = Convert.ToInt32(txtId.Text);
            patient.Name = txtName.Text;
            patient.LastName = txtLastName.Text;
            patient.Birthday = (int)Convert.ToInt32(txtBirthday.Text);
            patient.Gender = txtGender.Text;
            patient.Address = txtAddress.Text;
            patient.PhoneNumber = (int)Convert.ToInt32(txtPhoneNumber.Text);
            patient.Email = txtEmail.Text;

            db.Patients.Update(patient);
            db.SaveChanges(); MessageBox.Show("Hasta Kaydı Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPatientList();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtGender.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Patients.Count(c => c.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen Hasta Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var patient = new Patient();
            patient.Name = txtName.Text;
            patient.LastName = txtLastName.Text;
            patient.Birthday = (int)Convert.ToInt32(txtBirthday.Text);
            patient.Gender = txtGender.Text;
            patient.Address = txtAddress.Text;
            patient.Email = txtEmail.Text;
            patient.PhoneNumber = (int)Convert.ToInt32(txtPhoneNumber.Text);


            db.Patients.Add(patient);
            db.SaveChanges();
            MessageBox.Show("Hasta Kaydı Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPatientList();
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var patientid = db.Patients.Where(x => x.Id == id).SingleOrDefault();
            if (patientid == null)
            {
                MessageBox.Show("Geçerli Bir Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Patients.Remove(patientid);
            db.SaveChanges();
            MessageBox.Show("Hasta Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetPatientList();
            btnClear.PerformClick();
        }

        private void dgPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            txtBirthday.Text = dgPatient.CurrentRow.Cells[3].Value.ToString();
            txtGender.Text = dgPatient.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtPhoneNumber.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
