using PatientRecordApp.Core.Constants;
using System.Xml.Linq;

namespace PatientRecordApp.UI.Winforms.MDI.Helpers
{
    public static class SettingsHelper
    {
        public static void Write(string filePath)
        {
            var xml = new XElement(SettingsXMLElement.SETTINGS);
            var hospitalName = new XElement(SettingsXMLElement.HOSPITALNAME);

            var paths = new XElement(SettingsXMLElement.FILEPATH);
            paths.Add(new XElement(SettingsXMLElement.PATIENTCSV), string.Empty);
            paths.Add(new XElement(SettingsXMLElement.DOCTORCSV), string.Empty);

            var ids = new XElement(SettingsXMLElement.ID);
            ids.Add(new XElement(SettingsXMLElement.PATIENT), 0);
            ids.Add(new XElement(SettingsXMLElement.DOCTOR), 0);

            xml.Add(hospitalName);
            xml.Add(paths);
            xml.Add(ids);

            xml.Save(filePath);
        }
    }
}
