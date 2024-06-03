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
using System.Xml.Linq;

namespace Hasta_Takip_Programı.Forms
{
    public partial class FrmAppointment : Form
    {
        public FrmAppointment()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();

        private void FrmAppointment_Load(object sender, EventArgs e)
        {
            GetAppointmentList();
            dgDoctor.Visible = false;
            dgPatient.Visible = false;
            GetDoctorList();
            GetPatientList();
        }
        void GetAppointmentList()
        {
            dgAppointment.Rows.Clear();
            List<Appointment> appointments = db.Appointments.ToList();
            foreach (var appointment in appointments)
            {
                dgAppointment.Rows.Add(appointment.Id, appointment.PatientId, appointment.DoctorId, appointment.AppointmentDate, appointment.ReasonForVisit);
            }
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
            if (txtVisitReason.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçiniz ve Alanları Boş Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var appointmentid = Convert.ToInt32(txtId.Text);
            var appointment = db.Appointments.Where(x => x.Id == appointmentid).SingleOrDefault();
            if (appointmentid == null)
            {
                MessageBox.Show("Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            appointment.DoctorId = Convert.ToInt32(txtDoctorId.Text);
            appointment.PatientId = Convert.ToInt32(txtPatientId.Text);
            appointment.AppointmentDate = DateTime.Now;
            appointment.ReasonForVisit = txtVisitReason.Text;

            db.Appointments.Update(appointment);
            db.SaveChanges(); MessageBox.Show("Randevu Kaydı Güncellendi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAppointmentList();
            btnClear.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtVisitReason.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Appointments.Count(c => c.ReasonForVisit == txtVisitReason.Text) > 0)
            {
                MessageBox.Show("Girilen Randevu Numarası Kayıtlıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var appointment = new Appointment();
            appointment.DoctorId = Convert.ToInt32(txtDoctorId.Text);
            appointment.PatientId = Convert.ToInt32(txtPatientId.Text);
            appointment.AppointmentDate = DateTime.Now;
            appointment.ReasonForVisit = txtVisitReason.Text;

            db.Appointments.Add(appointment);
            db.SaveChanges();
            MessageBox.Show("Randevu Kaydı Eklendi!", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAppointmentList();
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
            var appointmentid = db.Appointments.Where(x => x.Id == id).SingleOrDefault();
            if (appointmentid == null)
            {
                MessageBox.Show("Geçerli Bir Kayıt Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Appointments.Remove(appointmentid);
            db.SaveChanges();
            MessageBox.Show("Randevu Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAppointmentList();
            btnClear.PerformClick();
        }

        private void dgAppointment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgAppointment.CurrentRow.Cells[0].Value.ToString();
            txtDoctorId.Text = dgAppointment.CurrentRow.Cells[1].Value.ToString();
            txtPatientId.Text = dgAppointment.CurrentRow.Cells[2].Value.ToString();
            txtVisitReason.Text = dgAppointment.CurrentRow.Cells[3].Value.ToString();

            dgDoctor.Visible = true;
            dgPatient.Visible = true;
            dgAppointment.Visible = true;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgDoctor.Visible = true;
            dgPatient.Visible = true;
            dgAppointment.Visible = true;
        }

        private void dgDoctor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgDoctor.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgDoctor.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgDoctor.CurrentRow.Cells[2].Value.ToString();
            txtProfession.Text = dgDoctor.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgDoctor.CurrentRow.Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgDoctor.CurrentRow.Cells[5].Value.ToString();

            dgDoctor.Visible = true;
            dgPatient.Visible = true;
            dgAppointment.Visible = true;
        }

        private void dgPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientId.Text = dgPatient.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgPatient.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgPatient.CurrentRow.Cells[2].Value.ToString();
            txtBirthday.Text = dgPatient.CurrentRow.Cells[3].Value.ToString();
            txtGender.Text = dgPatient.CurrentRow.Cells[4].Value.ToString();
            txtAddress.Text = dgPatient.CurrentRow.Cells[5].Value.ToString();
            txtPhoneNumber.Text = dgPatient.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgPatient.CurrentRow.Cells[7].Value.ToString();

            dgDoctor.Visible = true;
            dgPatient.Visible = true;
            dgAppointment.Visible = true;
        }
    }
}
//txtDoctorId.Text == "" || txtPatientId.Text == "" ||
//(int)Convert.ToInt32(appointment.DoctorId);
//(int)Convert.ToInt32(appointment.PatientId);