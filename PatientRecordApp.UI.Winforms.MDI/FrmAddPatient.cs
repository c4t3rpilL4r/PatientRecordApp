using PatientRecordApp.Core.Constants;
using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmAddPatient : Form
    {
        private IPatientManager _patientManager;
        private IDoctorManager _doctorManager;

        private IList<Doctor> _doctorList;

        public FrmAddPatient()
        {
            _patientManager = new PatientManager();
            _doctorManager = new DoctorManager();
            _doctorList = _doctorManager.Read();
            InitializeComponent();
        }

        private void FrmAddPatient_Load(object sender, EventArgs e) => PopulateComboBoxDoctor();

        private void TxtAge_TextChanged(object sender, EventArgs e) => PopulateComboBoxDoctor();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text)
                && !string.IsNullOrWhiteSpace(TxtSurname.Text)
                && !string.IsNullOrWhiteSpace(TxtAge.Text)
                && (!string.IsNullOrWhiteSpace(TxtAddress1.Text) || !string.IsNullOrWhiteSpace(TxtAddress2.Text))
                && !string.IsNullOrWhiteSpace(TxtCity.Text)
                && !string.IsNullOrWhiteSpace(TxtProvince.Text)
                && !string.IsNullOrWhiteSpace(TxtCountry.Text)
                && !string.IsNullOrWhiteSpace(TxtZipCode.Text)
                && !string.IsNullOrWhiteSpace(TxtContactNumber.Text)
                && !string.IsNullOrWhiteSpace(TxtEmailAddress.Text)
                && !string.IsNullOrWhiteSpace(TxtDiagnosis.Text)
                && CboDoctor.SelectedIndex != -1)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "settings.xml");
                var xmlDocument = XDocument.Load(path);
                var patientId = int.Parse(xmlDocument.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.ID).Element(SettingsXMLElement.PATIENT).Value) + 1;

                var selectedDoctor = CboDoctor.SelectedItem.ToString().Replace("Dr. ", string.Empty).Replace(",", string.Empty);

                var doctor = _doctorList.FirstOrDefault(x => selectedDoctor.Contains(x.FirstName) && selectedDoctor.Contains(x.LastName) && selectedDoctor.Contains(x.Department));

                var isSuccessful = _patientManager.Create(new Patient()
                {
                    Id = patientId,
                    FirstName = TxtFirstName.Text,
                    Surname = TxtSurname.Text,
                    Gender = RdoMale.Checked ? "Male" : "Female",
                    Age = int.Parse(TxtAge.Text),
                    Address1 = TxtAddress1.Text,
                    Address2 = TxtAddress2.Text,
                    City = TxtCity.Text,
                    Province = TxtProvince.Text,
                    Country = TxtCountry.Text,
                    ZipCode = int.Parse(TxtZipCode.Text),
                    ContactNumber = TxtContactNumber.Text,
                    EmailAddress = TxtEmailAddress.Text,
                    DateOfConsultation = DateTime.Now,
                    Diagnosis = TxtDiagnosis.Text,
                    DoctorId = doctor.Id
                });

                if (isSuccessful)
                {
                    xmlDocument.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.ID).Element(SettingsXMLElement.PATIENT).Value = patientId.ToString();
                    xmlDocument.Save(path);

                    MessageBox.Show("Patient adding successful.");
                }
                else
                {
                    MessageBox.Show("Patient adding failed.");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all details.");
            }
        }

        private void PopulateComboBoxDoctor()
        {
            CboDoctor.Items.Clear();

            CboDoctor.Items.AddRange(!string.IsNullOrWhiteSpace(TxtAge.Text)
                ? (int.Parse(TxtAge.Text) > 21
                    ? _doctorList.Where(x => x.Department.Equals("Family and Community Medicine")).Select(x => $"Dr. {x.FirstName} {x.LastName}, {x.Department} Department").ToArray()
                    : _doctorList.Where(x => x.Department.Equals("Pediatrics")).Select(x => $"Dr. {x.FirstName} {x.LastName}, {x.Department} Department").ToArray())
                : _doctorList.Select(x => $"Dr. {x.FirstName} {x.LastName}, {x.Department} Department").ToArray());
        }
    }
}
