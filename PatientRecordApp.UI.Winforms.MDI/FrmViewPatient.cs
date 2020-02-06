using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmViewPatient : Form
    {
        private readonly IPatientManager _patientManager;
        private readonly IDoctorManager _doctorManager;
        private readonly IList<Patient> _patientList;
        private readonly IList<Doctor> _doctorList;

        public FrmViewPatient()
        {
            _patientManager = new PatientManager();
            _doctorManager = new DoctorManager();
            _patientList = _patientManager.Read();
            _doctorList = _doctorManager.Read();
            InitializeComponent();
        }

        private void FrmViewPatient_Load(object sender, EventArgs e)
        {
            DisplayDataInListView(_patientList);
        }

        private void DisplayDataInListView(IList<Patient> patientList)
        {
            LvPatients.Items.Clear();

            var listViewItemList = new List<ListViewItem>();

            foreach (var patient in patientList.OrderBy(x => x.DateOfConsultation))
            {
                var propertyToBeExcluded = new List<string>();

                var doctor = _doctorList.FirstOrDefault(x => x.Id == patient.DoctorId);

                var row = new ListViewItem(patient.Id.ToString());
                row.SubItems.Add(patient.Surname);
                row.SubItems.Add(patient.FirstName);
                row.SubItems.Add(patient.Gender);
                row.SubItems.Add(patient.DateOfConsultation.ToString());
                row.SubItems.Add($"Dr. {doctor.FirstName} {doctor.LastName}, {doctor.Department}");

                row.Tag = patient;

                listViewItemList.Add(row);
            }

            LvPatients.Items.AddRange(listViewItemList.ToArray());
        }
    }
}
