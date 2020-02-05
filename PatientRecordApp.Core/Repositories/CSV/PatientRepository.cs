using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Repositories.CSV
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        protected override string FilePath => throw new System.NotImplementedException();

        protected override IList<Patient> DataList => throw new System.NotImplementedException();

        public bool Create(Patient data)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(List<Patient> dataList)
        {
            throw new System.NotImplementedException();
        }

        public IList<Patient> Read()
        {
            throw new System.NotImplementedException();
        }

        public IList<Patient> Search(SearchFilters filters)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Patient oldData, Patient newData)
        {
            throw new System.NotImplementedException();
        }
    }
}
