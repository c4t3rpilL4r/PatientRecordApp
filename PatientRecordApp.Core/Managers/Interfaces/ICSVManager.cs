using PatientRecordApp.Core.Models;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Managers.Interfaces
{
    public interface ICSVManager
    {
        bool Create(Patient patient);
        IList<Patient> Read();
        bool Update(Patient oldPatientRecord, Patient newPatientRecordt);
        bool Delete(List<Patient> patients);
    }
}
