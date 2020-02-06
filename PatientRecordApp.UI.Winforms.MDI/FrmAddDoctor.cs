﻿using PatientRecordApp.Core.Constants;
using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI
{
	public partial class FrmAddDoctor : Form
	{
		private readonly IDoctorManager _doctorManager;

		public FrmAddDoctor()
		{
			_doctorManager = new DoctorManager();
			InitializeComponent();
		}

		private void FrmAddDoctor_Load(object sender, System.EventArgs e)
		{
			CboDepartment.Items.Clear();
			CboDepartment.Items.Add("Pediatrics");
			CboDepartment.Items.Add("Family and Community Medicine");
		}

		private void BtnSave_Click(object sender, System.EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(TxtFirstName.Text)
				&& !string.IsNullOrWhiteSpace(TxtLastName.Text)
				&& CboDepartment.SelectedIndex != -1)
			{
				var path = Path.Combine(Directory.GetCurrentDirectory(), "settings.xml");
				var xmlDocument = XDocument.Load(path);
				var doctorId = int.Parse(xmlDocument.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.ID).Element(SettingsXMLElement.DOCTOR).Value) + 1;

				var isSuccessful = _doctorManager.Create(new Doctor()
				{
					Id = doctorId,
					FirstName = TxtFirstName.Text,
					LastName = TxtLastName.Text,
					Department = CboDepartment.SelectedItem.ToString()
				});

				if (isSuccessful)
				{
					xmlDocument.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.ID).Element(SettingsXMLElement.DOCTOR).Value = doctorId.ToString();
					xmlDocument.Save(path);

					MessageBox.Show("Doctor adding successful.");
				}
				else
				{
					MessageBox.Show("Doctor adding failed.");
				}
			}
			else
			{
				MessageBox.Show("Please fill in all details.");
			}
		}
	}
}
