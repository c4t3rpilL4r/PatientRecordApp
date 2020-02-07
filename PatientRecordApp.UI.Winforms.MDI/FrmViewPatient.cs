using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.UI.Winforms.MDI.Helpers;
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

        private Form _parentForm;

        public FrmViewPatient(Form parentForm)
        {
            _patientManager = new PatientManager();
            _doctorManager = new DoctorManager();
            _patientList = _patientManager.Read();
            _doctorList = _doctorManager.Read();
            _parentForm = parentForm;
            InitializeComponent();
        }

        private void FrmViewPatient_Activated(object sender, EventArgs e) => DisplayDataInListView(_patientList);

        private void LvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LvPatients.SelectedItems.Count > 0)
            {
                var form = new FrmAddEditPatient(LvPatients.SelectedItems[0].Tag as Patient);
                FormHelper.OpenForm(_parentForm, form);
            }
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
