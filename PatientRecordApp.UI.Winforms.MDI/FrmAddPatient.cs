using System;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmAddPatient : Form
    {
        public FrmAddPatient()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtFirstName.Text)
                && !string.IsNullOrWhiteSpace(TxtSurname.Text)
                && !string.IsNullOrWhiteSpace(TxtAddress1.Text)
                && !string.IsNullOrWhiteSpace(TxtAddress2.Text)
                && !string.IsNullOrWhiteSpace(TxtCity.Text)
                && !string.IsNullOrWhiteSpace(TxtProvince.Text)
                && !string.IsNullOrWhiteSpace(TxtCountry.Text)
                && !string.IsNullOrWhiteSpace(TxtZipCode.Text)
                && !string.IsNullOrWhiteSpace(TxtContactNumber.Text)
                && !string.IsNullOrWhiteSpace(TxtEmailAddress.Text)
                && !string.IsNullOrWhiteSpace(TxtDiagnosis.Text)
                && CboDoctor.SelectedIndex != -1)
            {

            }
        }
    }
}
