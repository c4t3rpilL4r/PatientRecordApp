using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
	public partial class FrmPatientRecordApp : Form
	{
		public FrmPatientRecordApp()
		{
			InitializeComponent();
		}

		private void FrmPatientRecordApp_Load(object sender, System.EventArgs e)
		{

		}

		private void patientToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			var form = new FrmAddPatient();
			OpenForm(form);
			form.MdiParent = this;
		}

		private void doctorToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			var form = new FrmAddDoctor();
			OpenForm(form);
			form.MdiParent = this;
		}

		private void OpenForm(Form form)
		{
			var child = this.MdiChildren.GetType();

			if (child.BaseType != null)
			{
				
			}
			else
			{
				form.Show();
			}
		}
	}
}
