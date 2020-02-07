using System.Linq;
using System.Windows.Forms;

namespace PatientRecordApp.UI.Winforms.MDI.Helpers
{
    public class FormHelper
    {
        public static void OpenForm(Form parentForm, Form form)
        {
            var child = parentForm.MdiChildren.FirstOrDefault(frm => frm.Name.Equals(form.Name));

            if (child != null)
            {
                child.BringToFront();
            }
            else
            {
                form.Show();
                form.MdiParent = parentForm;
            }
        }
    }
}
