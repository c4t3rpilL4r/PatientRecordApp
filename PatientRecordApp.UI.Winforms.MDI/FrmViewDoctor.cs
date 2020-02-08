using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.UI.Winforms.MDI.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
	public partial class FrmViewDoctor : Form
	{
		private readonly IDoctorManager _doctorManager;
		private readonly IList<Doctor> _doctorList;

		private Form _parentForm;

		public FrmViewDoctor(Form parentForm)
		{
			_doctorManager = new DoctorManager();
			_doctorList = _doctorManager.Read();
			_parentForm = parentForm;
			InitializeComponent();
		}

		private void FrmViewDoctor_Activated(object sender, EventArgs e) => DisplayDataInListView(_doctorList);

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (LvDoctor.SelectedItems.Count > 0)
			{
				var form = new FrmAddEditDoctor(LvDoctor.SelectedItems[0].Tag as Doctor);
				FormHelper.OpenForm(_parentForm, form);
			}
		}

		private void DisplayDataInListView(IList<Doctor> doctorList)
		{
			LvDoctor.Items.Clear();

			var listViewItemList = new List<ListViewItem>();

			foreach (var doctor in doctorList.OrderBy(x => x.Id))
			{
				var row = new ListViewItem(doctor.Id.ToString());
				row.SubItems.Add("Dr.");
				row.SubItems.Add(doctor.FirstName);
				row.SubItems.Add(doctor.LastName);
				row.SubItems.Add(doctor.Department);

				row.Tag = doctor;

				listViewItemList.Add(row);
			}

			LvDoctor.Items.AddRange(listViewItemList.ToArray());
		}
	}
}
