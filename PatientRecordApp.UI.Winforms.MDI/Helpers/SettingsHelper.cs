using System.IO;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI.Helpers
{
    public class SettingsHelper
    {
        public static string _hospitalName = string.Empty;
        public static string _patientCSVPath = string.Empty;
        public static string _doctorCSVPath = string.Empty;
        public static int _patientId = 0;
        public static int _doctorId = 0;

        public static void Save()
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Settings",
                    new XElement("HospitalName", _hospitalName)
                ),
                new XElement("File Path",
                    new XElement("PatientCSV", _patientCSVPath),
                    new XElement("DoctorCSV", _doctorCSVPath)
                ),
                new XElement("Id",
                    new XElement("Patient", _patientId),
                    new XElement("Doctor", _doctorId)
                )
            );

            xmlDocument.Save(Path.Combine(Directory.GetCurrentDirectory(), "Settings.xml"));
        }
    }
}
