using PatientRecordApp.Core.Constants;
using PatientRecordApp.UI.Winforms.MDI.Helpers;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmPatientRecordApp : Form
    {
        private readonly string _settingsFilePath = ConfigurationManager.AppSettings["SettingsXMLPath"];

        public FrmPatientRecordApp()
        {
            InitializeComponent();
        }

        private new void FrmPatientRecordApp_Activated(object sender, System.EventArgs e)
        {
            if (!File.Exists(_settingsFilePath))
            {
                SettingsHelper.Write(_settingsFilePath);
            }
            else // would experience error most of the time if removed ... don't know why
            {
                var xmlLoad = XDocument.Load(_settingsFilePath);
                this.Text = xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.HOSPITALNAME).Value;
            }
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

        private void settingsToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            var form = new FrmSettings();
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
                form.MdiParent = this;
            }
        }
    }
}
