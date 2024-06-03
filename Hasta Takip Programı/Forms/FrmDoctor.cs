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
    public partial class FrmDoctor : Form
    {
        public FrmDoctor()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            GetDoctorList();
        }
        void GetDoctorList()
        {
            dgDoctor.Rows.Clear();
            List<Doctor> doctors = db.Doctors.ToList();
            foreach (var doctor in doctors)
            {
                dgDoctor.Rows.Add(doctor.Id, doctor.Name, doctor.LastName, doctor.Profession, doctor.Email, doctor.PhoneNumber);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtLastName.Text == "" || txtProfession.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var doctorid = Convert.ToInt32(txtId.Text);
            var doctor = db.Doctors.Where(x => x.Id == doctorid).SingleOrDefault();
            if (doctorid == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //doctor.Id = Convert.ToInt32(txtId.Text);
            doctor.Name = txtName.Text;
            doctor.LastName = txtLastName.Text;
            doctor.Profession = txtProfession.Text;
            doctor.Email = txtEmail.Text;
            doctor.PhoneNumber = (int)Convert.ToInt32(txtPhoneNumber.Text);


            db.Doctors.Update(doctor);
            db.SaveChanges(); MessageBox.Show("Doktor Kaydı Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDoctorList();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" || txtProfession.Text == "" || txtEmail.Text == "" || txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Doctors.Count(c => c.Name == txtName.Text) > 0)
            {
                MessageBox.Show("Girilen Doktor Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var doctor = new Doctor();
            //doctor.Id = Convert.ToInt32(txtId.Text);
            doctor.Name = txtName.Text;
            doctor.LastName = txtLastName.Text;
            doctor.Profession = txtProfession.Text;
            doctor.Email = txtEmail.Text;
            doctor.PhoneNumber = (int)Convert.ToInt32(txtPhoneNumber.Text);

            db.Doctors.Add(doctor);
            db.SaveChanges();
            MessageBox.Show("Doktor Kaydı Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDoctorList();
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
            var doctorid = db.Doctors.Where(x => x.Id == id).SingleOrDefault();
            if (doctorid == null)
            {
                MessageBox.Show("Geçerli Bir Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Doctors.Remove(doctorid);
            db.SaveChanges();
            MessageBox.Show("Doktor Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDoctorList();
            btnClear.PerformClick();
        }

        private void FrmDoctor_Click(object sender, EventArgs e)
        {

        }

        private void dgDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgDoctor.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgDoctor.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgDoctor.CurrentRow.Cells[2].Value.ToString();
            txtProfession.Text = dgDoctor.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgDoctor.CurrentRow.Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgDoctor.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
