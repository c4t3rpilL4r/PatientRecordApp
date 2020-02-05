using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Repositories.CSV
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        protected override string FilePath => throw new NotImplementedException();

        protected override IList<Doctor> DataList => throw new NotImplementedException();

        public bool Create(Doctor data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<Doctor> dataList)
        {
            throw new NotImplementedException();
        }

        public IList<Doctor> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Doctor oldData, Doctor newData)
        {
            throw new NotImplementedException();
        }
    }
}
