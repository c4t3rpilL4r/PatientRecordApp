using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
                var isSuccessful = _patientManager.Create(new Patient()
                {
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
                    ContactNumber = int.Parse(TxtContactNumber.Text),
                    EmailAddress = TxtEmailAddress.Text,
                    Diagnosis = TxtDiagnosis.Text
                });

                MessageBox.Show(isSuccessful ? "Patient adding successful." : "Patient adding failed."); ;
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
