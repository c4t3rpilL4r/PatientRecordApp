using PatientRecordApp.Core.Managers.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories;
using PatientRecordApp.Core.Repositories.Interfaces;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Managers
{
    public class CSVBaseManager : ICSVManager
    {
        private ICSVRepository repository = new CSVBaseRepository();

        public bool Create(Patient patient)
        {
            return repository.Create(patient);
        }

        public IList<Patient> Read()
        {
            return repository.Read();
        }

        public bool Update(Patient oldPatientRecord, Patient newPatientRecord)
        {
            return repository.Update(oldPatientRecord, newPatientRecord);
        }

        public bool Delete(List<Patient> patients)
        {
            return repository.Delete(patients);
        }

        public IList<Patient> FindByWhereCondition(string keyword)
        {
            return repository.FindByWhereCondition(keyword);
        }
    }
}
