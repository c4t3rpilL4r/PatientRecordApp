using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmPatientRecordApp : Form
    {
        public FrmPatientRecordApp()
        {
            InitializeComponent();
        }

        private void FrmPatientRecordApp_Load(object sender, System.EventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FrmAddPatient();
            OpenForm(form);
        }

        private void doctorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FrmAddDoctor();
            OpenForm(form);
        }

        private void OpenForm(Form form)
        {
            var child = MdiChildren.FirstOrDefault(frm => frm.Name.Equals(form.Name));

            if (child != null)
            {
                child.BringToFront();
            }
            else
            {
                form.Show();
            }

            form.MdiParent = this;
        }
    }
}
