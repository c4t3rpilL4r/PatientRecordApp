using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmPatientRecordApp : Form
    {
        public FrmPatientRecordApp()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var frmAddPatient = new FrmAddPatient();
            frmAddPatient.MdiParent = this;
            frmAddPatient.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
