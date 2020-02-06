using PatientRecordApp.Core.Constants;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI
{
	public partial class FrmSettings : Form
	{
		private readonly static string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "settings.xml");
		private readonly XDocument _xmlLoad;

		public FrmSettings()
		{
			_xmlLoad = XDocument.Load(_filePath);
			InitializeComponent();
		}

		private void FrmSettings_Load(object sender, System.EventArgs e)
		{
			var hospitalName = _xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.HOSPITALNAME).Value;
			var patientCsv = _xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.FILEPATH).Element(SettingsXMLElement.PATIENTCSV).Value;
			var doctorCsv = _xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.FILEPATH).Element(SettingsXMLElement.DOCTORCSV).Value;

			TxtHospitalName.Text = hospitalName;
			TxtPatientCSVPath.Text = patientCsv;
			TxtDoctorCSVPath.Text = doctorCsv;
		}

		private void BtnPatientCSVBrowse_Click(object sender, EventArgs e) => TxtPatientCSVPath.Text = GetCSVPathDirectory();

		private void BtnDoctorCSVBrowse_Click(object sender, EventArgs e) => TxtDoctorCSVPath.Text = GetCSVPathDirectory();

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (!string.IsNullOrWhiteSpace(TxtHospitalName.Text)
					&& !string.IsNullOrWhiteSpace(TxtPatientCSVPath.Text)
					&& !string.IsNullOrWhiteSpace(TxtDoctorCSVPath.Text))
				{
					if (CheckFileIfExists(TxtPatientCSVPath.Text) && CheckFileIfExists(TxtDoctorCSVPath.Text))
					{
						_xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.HOSPITALNAME).Value = TxtHospitalName.Text;
						_xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.FILEPATH).Element(SettingsXMLElement.PATIENTCSV).Value = TxtPatientCSVPath.Text;
						_xmlLoad.Element(SettingsXMLElement.SETTINGS).Element(SettingsXMLElement.FILEPATH).Element(SettingsXMLElement.DOCTORCSV).Value = TxtDoctorCSVPath.Text;
						_xmlLoad.Save(_filePath);

						MessageBox.Show("Settings saved.");
					}
				}
				else
				{
					MessageBox.Show("Please fill in all details.");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Settings not saved.");
			}
		}

		private string GetCSVPathDirectory()
		{
			var openFile = new OpenFileDialog();
			var path = string.Empty;

			if (openFile.ShowDialog().Equals(DialogResult.OK))
			{
				path = openFile.FileName;
			}

			return path;
		}

		private bool CheckFileIfExists(string path)
		{
			var isExisting = true;

			if (!File.Exists(path))
			{
				MessageBox.Show($"No file at path: {path}.");
				isExisting = false;
			}

			return isExisting;
		}
	}
}
