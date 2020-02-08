using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms
{
	public partial class FrmPatientApp : Form
	{
		private readonly IPatientManager _manager;
		private readonly IList<Patient> _patientList;
		private static bool _resetFlag;

		public FrmPatientApp()
		{
			_manager = new PatientManager();
			_patientList = _manager.Read();
			_resetFlag = false;
			InitializeComponent();
		}

		private void FrmPatientApp_Activated(object sender, EventArgs e)
		{
			CboDiagnosis.Items.Clear();
			CboDiagnosis.Items.AddRange(_patientList.OrderBy(x => x.Diagnosis).Select(x => x.Diagnosis).Distinct().ToArray());

			DisplayDataInListView(_patientList);
		}

		private void BtnAddPatient_Click(object sender, EventArgs e)
		{
			var frmAddEditPatient = new FrmAddEditPatient();
			frmAddEditPatient.Show();

			DisplayDataInListView(_manager.Search(RetrieveDataFromFilters()));
		}

		private void BtnEditPatient_Click(object sender, EventArgs e)
		{
			if (LvPatients.SelectedItems.Count > 0)
			{
				var frmAddEditPatient = new FrmAddEditPatient(LvPatients.SelectedItems[0].Tag as Patient);
				frmAddEditPatient.Show();
			}

			DisplayDataInListView(_manager.Search(RetrieveDataFromFilters()));
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

				MessageBox.Show(_manager.Delete(patientList) ? "Patient/s deletion successful." : "Patient/s deletion failed.");
			}

			DisplayDataInListView(_manager.Search(RetrieveDataFromFilters()));
		}

		private void LvPatients_SelectedIndexChanged(object sender, EventArgs e)
		{
			BtnDeletePatient.Enabled = LvPatients.SelectedItems.Count > 0;
			BtnEditPatient.Enabled = LvPatients.SelectedItems.Count == 1;
		}

		private void BtnSearch_Click(object sender, EventArgs e) => DisplayDataInListView(_manager.Search(RetrieveDataFromFilters()));

		private void RdbMale_CheckedChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void RdbFemale_CheckedChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void DtpDateOfConsultation_ValueChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void CboDiagnosis_SelectedIndexChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void BtnResetSearch_Click(object sender, EventArgs e)
		{
			DisplayDataInListView(_patientList);

			_resetFlag = true;
			TxtSearch.Clear();
			RdbMale.Checked = false;
			RdbFemale.Checked = false;
			DtpDateOfConsultation.ResetText();
			CboDiagnosis.ResetText();
			_resetFlag = false;
		}

		private void DisplayDataInListView(IList<Patient> patientList)
		{
			LvPatients.Items.Clear();

			var listViewItemList = new List<ListViewItem>();

			foreach (var patient in patientList.OrderBy(x => x.DateOfConsultation))
			{
				var row = new ListViewItem(patient.Surname);
				row.SubItems.Add(patient.FirstName);
				row.SubItems.Add(patient.Gender);
				row.SubItems.Add(patient.DateOfConsultation.ToString());
				row.SubItems.Add(patient.Diagnosis);

				row.Tag = patient;

				listViewItemList.Add(row);
			}

			LvPatients.Items.AddRange(listViewItemList.ToArray());
		}

		private void RunSearchFilterEvent()
		{
			if (!_resetFlag)
			{
				DisplayDataInListView(_manager.Search(RetrieveDataFromFilters()));
			}
		}

		private SearchFilters RetrieveDataFromFilters()
		{
			var gender = string.Empty;

			if (RdbMale.Checked)
			{
				gender = "Male";
			}
			else if (RdbFemale.Checked)
			{
				gender = "Female";
			}

			var filter = new SearchFilters();

			filter.FullName = TxtSearch.Text;
			filter.Gender = gender;
			filter.DateOfConsultation = DtpDateOfConsultation.Value.Date.ToString().Substring(0, 10);
			filter.Diagnosis = CboDiagnosis.SelectedIndex != -1 ? CboDiagnosis.SelectedItem.ToString() : string.Empty;

			return filter;
		}
	}
}
