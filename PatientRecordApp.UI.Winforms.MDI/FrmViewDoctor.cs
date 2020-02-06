using PatientRecordApp.Core.Managers.CSV;
using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI
{
    public partial class FrmViewDoctor : Form
    {
        private readonly IDoctorManager _doctorManager;
        private readonly IList<Doctor> _doctorList;

        public FrmViewDoctor()
        {
            _doctorManager = new DoctorManager();
            _doctorList = _doctorManager.Read();
            InitializeComponent();
        }

        private void FrmViewDoctor_Load(object sender, EventArgs e)
        {
            DisplayDataInListView(_doctorList);
        }

        private void DisplayDataInListView(IList<Doctor> doctorList)
        {
            LvDoctor.Items.Clear();

            var listViewItemList = new List<ListViewItem>();

            foreach (var doctor in doctorList.OrderBy(x => x.Id))
            {
                var row = new ListViewItem(doctor.Id.ToString());
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
