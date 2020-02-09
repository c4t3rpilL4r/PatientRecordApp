using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.UI.Winforms.MDI.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
		private static string _date;
		private static bool _resetFlag;

		public FrmViewPatient(Form parentForm)
		{
			_patientManager = new PatientManager();
			_doctorManager = new DoctorManager();
			_patientList = _patientManager.Read();
			_doctorList = _doctorManager.Read();
			_parentForm = parentForm;
			InitializeComponent();
		}

		private void FrmViewPatient_Activated(object sender, EventArgs e)
		{
			CboDoctor.Items.Clear();
			CboDoctor.Items.AddRange(_patientList.Select(x =>
			{
				var doctor = _doctorList.FirstOrDefault(y => y.Id == x.DoctorId);
				return $"Dr. {doctor.FirstName} {doctor.LastName}, {doctor.Department}";
			}).Distinct().ToArray());

			DisplayDataInListView(_patientList);
		}

		private void LvPatients_MouseDown(object sender, MouseEventArgs e)
		{
			var lvItem = LvPatients.GetItemAt(e.X, e.Y);

			if (lvItem != null)
			{
				if (e.Button.Equals(MouseButtons.Right))
				{
					foreach (ToolStripMenuItem item in CmsPatient.Items)
					{
						item.Enabled = !(LvPatients.SelectedItems.Count == 0 && (item.Text.Equals("Edit") || item.Text.Equals("Delete")));
					}
				}
			}
		}

		private void LvPatients_MouseMove(object sender, MouseEventArgs e)
		{
			var lvItem = LvPatients.GetItemAt(e.X, e.Y);

			if (lvItem == null)
			{
				TtDiagnosis.Hide(this);
				return;
			}

			var diagnosis = _patientList.FirstOrDefault(x => x.Id == int.Parse(lvItem.SubItems[0].Text)).Diagnosis;

			TtDiagnosis.Show($"Diagnosis: {diagnosis}", this.LvPatients, new Point(e.X + 10, e.Y + 10));
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new FrmAddEditPatient();
			FormHelper.OpenForm(_parentForm, form);
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (LvPatients.SelectedItems.Count > 0)
			{
				var form = new FrmAddEditPatient(LvPatients.SelectedItems[0].Tag as Patient);
				FormHelper.OpenForm(_parentForm, form);
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (LvPatients.SelectedItems.Count > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete data?",
					"Delete Verification",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					var patientsToBeDeleted = new List<int>();

					LvPatients.SelectedItems.Cast<ListViewItem>().ToList().ForEach(x => patientsToBeDeleted.Add(int.Parse(x.SubItems[0].Text)));

					MessageBox.Show(_patientManager.Delete(patientsToBeDeleted) ? "Patient/s deletion successful." : "Patient/s deletion failed.");
				}
			}

			DisplayDataInListView(_patientManager.Search(RetrieveDataFromFilters()));
		}

		private void BtnSearch_Click(object sender, EventArgs e) => DisplayDataInListView(_patientManager.Search(RetrieveDataFromFilters()));

		private void DtpDateOfConsultation_ValueChanged(object sender, EventArgs e)
		{
			_date = DtpDateOfConsultation.Value.Date.ToString().Substring(0, 10);
			RunSearchFilterEvent();
		}

		private void RdbMale_CheckedChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void RdbFemale_CheckedChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void CboDoctor_SelectedIndexChanged(object sender, EventArgs e) => RunSearchFilterEvent();

		private void BtnResetSearch_Click(object sender, EventArgs e)
		{
			DisplayDataInListView(_patientList);

			_resetFlag = true;
			TxtSearch.Clear();
			RdbMale.Checked = false;
			RdbFemale.Checked = false;
			DtpDateOfConsultation.ResetText();
			CboDoctor.ResetText();
			_resetFlag = false;
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
				row.SubItems.Add(doctor.Id.ToString());
				row.SubItems.Add($"Dr. {doctor.FirstName} {doctor.LastName}, {doctor.Department}");

				row.Tag = patient;

				listViewItemList.Add(row);
			}

			LvPatients.Items.AddRange(listViewItemList.ToArray());
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

			int doctorId;

			if (CboDoctor.SelectedIndex != -1)
			{
				var cboDoctor = CboDoctor.SelectedItem.ToString().Replace("Dr. ", string.Empty).Split(',');

				doctorId = _doctorList.FirstOrDefault(x => cboDoctor[0].Equals($"{x.FirstName} {x.LastName}") && cboDoctor[1].Trim(' ').Equals(x.Department)).Id;
			}
			else
			{
				doctorId = 0;
			}

			var filter = new SearchFilters()
			{
				FullName = TxtSearch.Text,
				Gender = gender,
				DateOfConsultation = _date,
				DoctorId = doctorId
			};

			return filter;
		}

		private void RunSearchFilterEvent()
		{
			if (!_resetFlag)
			{
				DisplayDataInListView(_patientManager.Search(RetrieveDataFromFilters()));
			}
		}
	}
}
