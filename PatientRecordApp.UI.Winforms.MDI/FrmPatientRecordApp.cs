using PatientRecordApp.Core.Constants;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmPatientRecordApp : Form
    {
        public FrmPatientRecordApp()
        {
            InitializeComponent();
        }

        private new void FrmPatientRecordApp_Activated(object sender, System.EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "settings.xml");

            if (!File.Exists(path))
            {
                var xml = new XElement(SettingsXMLElement.SETTINGS);
                var hospitalName = new XElement(SettingsXMLElement.HOSPITALNAME, string.Empty);

                var paths = new XElement(SettingsXMLElement.FILEPATH);
                paths.Add(new XElement(SettingsXMLElement.PATIENTCSV, @"D:\PatientRecordApp\PatientRecordApp.Core\CSV\patients.csv"));
                paths.Add(new XElement(SettingsXMLElement.DOCTORCSV, @"D:\PatientRecordApp\PatientRecordApp.Core\CSV\doctors.csv"));

                var ids = new XElement(SettingsXMLElement.ID);
                ids.Add(new XElement(SettingsXMLElement.PATIENT, 0));
                ids.Add(new XElement(SettingsXMLElement.DOCTOR, 0));

                xml.Add(hospitalName);
                xml.Add(paths);
                xml.Add(ids);

                xml.Save(path);
            }

            var xmlLoad = XDocument.Load(path);
            this.Text = xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.HOSPITALNAME).Value;
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

        private void patientsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FrmViewPatient();
            OpenForm(form);
        }

        private void doctorsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FrmViewDoctor();
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
