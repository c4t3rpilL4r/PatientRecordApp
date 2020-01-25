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
		private static IList<Patient> _patientSearchList;
		private static string _nameValue;
		private static string _genderValue;
		private static string _dateOfConsultationValue;
		private static string _diagnosisValue;
		private static bool _resetFlag;

		public FrmPatientApp()
		{
			_manager = new CSVBaseManager();
			_patientList = _manager.Read();
			_patientSearchList = new List<Patient>();
			_nameValue = string.Empty;
			_genderValue = string.Empty;
			_dateOfConsultationValue = string.Empty;
			_diagnosisValue = string.Empty;
			_resetFlag = false;
			InitializeComponent();
		}

		private void FrmPatientApp_Activated(object sender, EventArgs e)
		{
			var patientList = _manager.Read();

			CboDiagnosis.Items.Clear();
			CboDiagnosis.Items.AddRange(patientList.OrderBy(x => x.Diagnosis).Select(x => x.Diagnosis).Distinct().ToArray());

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
			if (!string.IsNullOrWhiteSpace(_nameValue))
			{
				_patientSearchList = _patientList;

				if (!string.IsNullOrWhiteSpace(_genderValue))
				{
					FilterByGender(_genderValue);
				}

				if (!string.IsNullOrWhiteSpace(_dateOfConsultationValue))
				{
					FilterByDateOfConsultation(_dateOfConsultationValue);
				}

				if (!string.IsNullOrWhiteSpace(_diagnosisValue))
				{
					FilterByDiagnosis(_diagnosisValue);
				}
			}

			_nameValue = TxtSearch.Text;

			SearchByName(_nameValue);

			DisplayDataInListView(_patientSearchList);
		}

		private void RdbMale_CheckedChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				if (!string.IsNullOrWhiteSpace(_genderValue))
				{
					_patientSearchList = _patientList;

					if (!string.IsNullOrWhiteSpace(_dateOfConsultationValue))
					{
						FilterByDateOfConsultation(_dateOfConsultationValue);
					}

					if (!string.IsNullOrWhiteSpace(_diagnosisValue))
					{
						FilterByDiagnosis(_diagnosisValue);
					}

					if (!string.IsNullOrWhiteSpace(_nameValue))
					{
						SearchByName(_nameValue);
					}
				}

				_genderValue = RdbMale.Text;

				FilterByGender(_genderValue);

				DisplayDataInListView(_patientSearchList);
			}
		}

		private void RdbFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				if (!string.IsNullOrWhiteSpace(_genderValue))
				{
					_patientSearchList = _patientList;

					if (!string.IsNullOrWhiteSpace(_dateOfConsultationValue))
					{
						FilterByDateOfConsultation(_dateOfConsultationValue);
					}

					if (!string.IsNullOrWhiteSpace(_diagnosisValue))
					{
						FilterByDiagnosis(_diagnosisValue);
					}

					if (!string.IsNullOrWhiteSpace(_nameValue))
					{
						SearchByName(_nameValue);
					}
				}

				_genderValue = RdbFemale.Text;

				FilterByGender(_genderValue);

				DisplayDataInListView(_patientSearchList);
			}
		}

		private void DtpDateOfConsultation_ValueChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				if (!string.IsNullOrWhiteSpace(_dateOfConsultationValue))
				{
					_patientSearchList = _patientList;

					if (!string.IsNullOrWhiteSpace(_genderValue))
					{
						FilterByGender(_genderValue);
					}

					if (!string.IsNullOrWhiteSpace(_diagnosisValue))
					{
						FilterByDiagnosis(_diagnosisValue);
					}

					if (!string.IsNullOrWhiteSpace(_nameValue))
					{
						SearchByName(_nameValue);
					}
				}

				_dateOfConsultationValue = DtpDateOfConsultation.Value.Date.ToString().Substring(0, 10);

				FilterByDateOfConsultation(_dateOfConsultationValue);

				DisplayDataInListView(_patientSearchList);
			}
		}

		private void CboDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!_resetFlag)
			{
				if (!string.IsNullOrWhiteSpace(_diagnosisValue))
				{
					_patientSearchList = _patientList;

					if (!string.IsNullOrWhiteSpace(_genderValue))
					{
						FilterByGender(_genderValue);
					}

					if (!string.IsNullOrWhiteSpace(_dateOfConsultationValue))
					{
						FilterByDateOfConsultation(_dateOfConsultationValue);
					}

					if (!string.IsNullOrWhiteSpace(_nameValue))
					{
						SearchByName(_nameValue);
					}
				}

				_diagnosisValue = CboDiagnosis.SelectedItem.ToString();

				FilterByDiagnosis(_diagnosisValue);

				DisplayDataInListView(_patientSearchList);
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
			_patientSearchList = new List<Patient>();
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

		private void SearchByName(string name)
		{
			var searchList = new List<Patient>();

			if (_patientSearchList.Count == 0)
			{
				foreach (Patient patient in _patientList)
				{
					var counter = 0;
					var nameSplit = name.Split(' ');
					var fullName = $"{patient.FirstName} {patient.Surname}";

					foreach (var split in nameSplit)
					{
						while (fullName.ToLower().Contains(split.ToLower()))
						{
							counter++;
							break;
						}

						if (counter == nameSplit.Length)
						{
							_patientSearchList.Add(patient);
						}
					}
				}
			}
			else
			{
				foreach (Patient patient in _patientSearchList)
				{
					var counter = 0;
					var nameSplit = name.Split(' ');
					var fullName = $"{patient.FirstName} {patient.Surname}";

					foreach (var split in nameSplit)
					{
						while (fullName.ToLower().Contains(split.ToLower()))
						{
							counter++;
							break;
						}

						if (counter == nameSplit.Length)
						{
							searchList.Add(patient);
						}
					}
				}

				_patientSearchList = searchList;
			}
		}

		private void FilterByGender(string gender)
		{
			var genderList = new List<Patient>();

			if (_patientSearchList.Count == 0)
			{
				foreach (Patient patient in _patientList)
				{
					if (patient.Gender.Equals(gender))
					{
						_patientSearchList.Add(patient);
					}
				}
			}
			else
			{
				foreach (Patient patient in _patientSearchList)
				{
					if (patient.Gender.Equals(gender))
					{
						genderList.Add(patient);
					}
				}

				_patientSearchList = genderList;
			}
		}

		private void FilterByDateOfConsultation(string dateOfConsultation)
		{
			var dateOfConsultationList = new List<Patient>();

			if (_patientSearchList.Count == 0)
			{
				foreach (Patient patient in _patientList)
				{
					if (patient.DateOfConsultation.Date.ToString().Contains(dateOfConsultation))
					{
						_patientSearchList.Add(patient);
					}
				}
			}
			else
			{
				foreach (Patient patient in _patientSearchList)
				{
					if (patient.DateOfConsultation.Date.ToString().Contains(dateOfConsultation))
					{
						dateOfConsultationList.Add(patient);
					}
				}

				_patientSearchList = dateOfConsultationList;
			}
		}

		private void FilterByDiagnosis(string diagnosis)
		{
			var diagnosisList = new List<Patient>();

			if (_patientSearchList.Count == 0)
			{
				foreach (Patient patient in _patientList)
				{
					if (patient.Diagnosis.Equals(diagnosis))
					{
						_patientSearchList.Add(patient);
					}
				}
			}
			else
			{
				foreach (Patient patient in _patientSearchList)
				{
					if (patient.Diagnosis.Equals(diagnosis))
					{
						diagnosisList.Add(patient);
					}
				}

				_patientSearchList = diagnosisList;
			}
		}
	}
}
