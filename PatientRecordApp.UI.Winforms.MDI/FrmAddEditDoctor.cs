using PatientRecordApp.Core.Constants;
using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmAddEditDoctor : Form
    {
        private readonly IDoctorManager _doctorManager;

        private Doctor _doctor;

        public FrmAddEditDoctor(Doctor doctor = null)
        {
            _doctorManager = new DoctorManager();
            _doctor = doctor;
            InitializeComponent();
        }

        private void FrmAddEditDoctor_Activated(object sender, System.EventArgs e)
        {
            CboDepartment.Items.Clear();
            CboDepartment.Items.Add("Pediatrics");
            CboDepartment.Items.Add("Family and Community Medicine");

            if (_doctor != null)
            {
                TxtFirstName.Text = _doctor.FirstName;
                TxtLastName.Text = _doctor.LastName;
                CboDepartment.SelectedItem = CboDepartment.Items.Cast<string>().FirstOrDefault(x => x.Contains(_doctor.Department));
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text)
                && !string.IsNullOrWhiteSpace(TxtLastName.Text)
                && CboDepartment.SelectedIndex != -1)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "settings.xml");
                var xmlDocument = XDocument.Load(path);
                var doctorId = int.Parse(xmlDocument.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.ID).Element(SettingsXMLElement.DOCTOR).Value) + 1;

                var isSuccessful = _doctorManager.Create(new Doctor()
                {
                    Id = doctorId,
                    FirstName = TxtFirstName.Text,
                    LastName = TxtLastName.Text,
                    Department = CboDepartment.SelectedItem.ToString()
                });

                if (isSuccessful)
                {
                    xmlDocument.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.ID).Element(SettingsXMLElement.DOCTOR).Value = doctorId.ToString();
                    xmlDocument.Save(path);

                    MessageBox.Show("Doctor adding successful.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Doctor adding failed.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all details.");
            }
        }
    }
}
