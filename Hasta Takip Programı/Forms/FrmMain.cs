using Hasta_Takip_Programı.Forms;

namespace Hasta_Takip_Programı
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        void OpenForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAppointment());
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDoctor());
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPatient());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
