using PatientRecordApp.Core.Managers;
using PatientRecordApp.Core.Managers.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms
{
    public partial class FrmPatientApp : Form
    {
        private readonly ICSVManager _manager = new CSVBaseManager();

        public FrmPatientApp()
        {
            InitializeComponent();
        }

        private void FrmPatientApp_Activated(object sender, EventArgs e)
        {
            var patientList = _manager.Read();
            
            DisplayDataInListView(patientList);
        }

        private void BtnAddPatient_Click(object sender, EventArgs e)
        {
            var frmAddEditPatient = new FrmAddEditPatient();
            frmAddEditPatient.Show();
        }

        private void BtnEditPatient_Click(object sender, EventArgs e)
        {
            if (LvPatients.SelectedItems.Count > 0)
            {
                var frmAddEditPatient = new FrmAddEditPatient(LvPatients.SelectedItems[0].Tag as Patient);
                frmAddEditPatient.Show();
            }
        }

        private void BtnDeletePatient_Click(object sender, EventArgs e)
        {
            if (LvPatients.SelectedItems.Count > 0)
            {
                List<Patient> patientList = new List<Patient>();

                foreach (ListViewItem patient in LvPatients.SelectedItems)
                {
                    patientList.Add(new Patient()
                    {
                        Surname = patient.SubItems[0].Text,
                        FirstName = patient.SubItems[1].Text,
                        Gender = patient.SubItems[2].Text,
                        DateOfConsultation = DateTime.Parse(patient.SubItems[3].Text),
                        Diagnosis = patient.SubItems[4].Text
                    });
                }

                if (_manager.Delete(patientList))
                {
                    MessageBox.Show("Patient/s deletion successful.");
                    LvPatients.Refresh();
                }
                else
                {
                    MessageBox.Show("Patient/s deletion failed.");
                }
            }
        }

        private void LvPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnDeletePatient.Enabled = LvPatients.SelectedItems.Count > 0;
            BtnEditPatient.Enabled = LvPatients.SelectedItems.Count == 1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var patientSearchList = _manager.FindByWhereCondition(TxtSearch.Text);

            DisplayDataInListView(patientSearchList);
        }

        private void BtnResetSearch_Click(object sender, EventArgs e)
        {
            var patientList = _manager.Read();

            DisplayDataInListView(patientList);

            TxtSearch.Clear();
        }

        private void DisplayDataInListView(IList<Patient> patientList)
        {
            LvPatients.Items.Clear();

            foreach (var patient in patientList.OrderBy(x => x.DateOfConsultation))
            {
                var row = new ListViewItem(patient.Surname);
                row.SubItems.Add(patient.FirstName);
                row.SubItems.Add(patient.Gender);
                row.SubItems.Add(patient.DateOfConsultation.ToString());
                row.SubItems.Add(patient.Diagnosis);

                row.Tag = patient;

                LvPatients.Items.Add(row);
            }
        }
    }
}
