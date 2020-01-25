using PatientRecordApp.Core.Managers;
using PatientRecordApp.Core.Managers.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms
{
	public partial class FrmAddEditPatient : Form
	{
		private ICSVManager _manager;
		private Patient _patient;

		public FrmAddEditPatient(Patient patient = null)
		{
			_manager = new CSVBaseManager();
			_patient = patient;
			InitializeComponent();
		}

		private void FrmAddEditPatient_Load(object sender, EventArgs e)
		{
			if (_patient != null)
			{
				TxtFirstName.Text = _patient.FirstName;
				TxtSurname.Text = _patient.Surname;
				CheckRadioButton(_patient.Gender);
				TxtDiagnosis.Text = _patient.Diagnosis;

				this.Text = "Edit Patient";
			}
			else
			{
				this.Text = "Add Patient";
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(TxtFirstName.Text)
			&& !string.IsNullOrWhiteSpace(TxtSurname.Text)
			&& CheckIfRadioButtonsAreChecked()
			&& !string.IsNullOrWhiteSpace(TxtDiagnosis.Text))
			{
				if (_patient != null)
				{
					var isSuccessful = _manager.Update(_patient, new Patient()
					{
						Surname = TxtSurname.Text,
						FirstName = TxtFirstName.Text,
						Gender = CheckWhatRadioButtonIsChecked(),
						DateOfConsultation = _patient.DateOfConsultation,
						Diagnosis = TxtDiagnosis.Text
					});

					MessageBox.Show(isSuccessful ? "Patient editing successful." : "Patient editing failed.");
				}
				else
				{
					var isSuccessful = _manager.Create(new Patient()
					{
						Surname = TxtSurname.Text,
						FirstName = TxtFirstName.Text,
						Gender = CheckWhatRadioButtonIsChecked(),
						DateOfConsultation = DateTime.Now,
						Diagnosis = TxtDiagnosis.Text
					});

					MessageBox.Show(isSuccessful ? "Patient adding successful." : "Patient adding failed.");
				}

				var frmPatientApp = new FrmPatientApp();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Please fill in all the details. Thank you.");
			}
		}

		private bool CheckIfRadioButtonsAreChecked()
		{
			var isChecked = false;

			foreach (RadioButton radio in GbGender.Controls.OfType<RadioButton>())
			{
				if (radio.Checked)
				{
					isChecked = true;
					break;
				}
			}

			return isChecked;
		}

		private string CheckWhatRadioButtonIsChecked()
		{
			var radioButton = string.Empty;

			foreach (RadioButton radio in GbGender.Controls.OfType<RadioButton>())
			{
				if (radio.Checked)
				{
					radioButton = radio.Text;
					break;
				}
			}

			return radioButton;
		}

		private void CheckRadioButton(string gender)
		{
			foreach (RadioButton radio in GbGender.Controls.OfType<RadioButton>())
			{
				if (radio.Text.Equals(gender))
				{
					radio.Select();
					break;
				}
			}
		}
	}
}
