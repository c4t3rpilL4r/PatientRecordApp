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
		private readonly ICSVManager _manager;
		private readonly IList<Patient> _patientList;
		private static string _nameValue;
		private static string _genderValue;
		private static string _dateOfConsultationValue;
		private static string _diagnosisValue;
		private static bool _resetFlag;

		public FrmPatientApp()
		{
			_manager = new CSVBaseManager();
			_patientList = _manager.Read();
			_nameValue = string.Empty;
			_genderValue = string.Empty;
			_dateOfConsultationValue = string.Empty;
			_diagnosisValue = string.Empty;
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
			_nameValue = TxtSearch.Text;

			DisplayDataInListView(_manager.RetrieveDataThroughSearchFilters(_nameValue, _genderValue, _dateOfConsultationValue, _diagnosisValue));
		}

		private void RdbMale_CheckedChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				_genderValue = RdbMale.Text;

				DisplayDataInListView(_manager.RetrieveDataThroughSearchFilters(_nameValue, _genderValue, _dateOfConsultationValue, _diagnosisValue));
			}
		}

		private void RdbFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				_genderValue = RdbFemale.Text;

				DisplayDataInListView(_manager.RetrieveDataThroughSearchFilters(_nameValue, _genderValue, _dateOfConsultationValue, _diagnosisValue));
			}
		}

		private void DtpDateOfConsultation_ValueChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				_dateOfConsultationValue = DtpDateOfConsultation.Value.Date.ToString().Substring(0, 10);

				DisplayDataInListView(_manager.RetrieveDataThroughSearchFilters(_nameValue, _genderValue, _dateOfConsultationValue, _diagnosisValue));
			}
		}

		private void CboDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				_diagnosisValue = CboDiagnosis.SelectedItem.ToString();

				DisplayDataInListView(_manager.RetrieveDataThroughSearchFilters(_nameValue, _genderValue, _dateOfConsultationValue, _diagnosisValue));
			}
		}

		private void BtnResetSearch_Click(object sender, EventArgs e)
		{
			DisplayDataInListView(_patientList);

			_resetFlag = true;
			TxtSearch.Clear();
			_nameValue = string.Empty;
			RdbMale.Checked = false;
			RdbFemale.Checked = false;
			_genderValue = string.Empty;
			DtpDateOfConsultation.ResetText();
			_dateOfConsultationValue = string.Empty;
			CboDiagnosis.ResetText();
			_diagnosisValue = string.Empty;
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
	}
}
