using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Repositories.CSV
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        protected override string FilePath => throw new NotImplementedException();

        protected override IList<Address> DataList => throw new NotImplementedException();

        public bool Create(Address data)
        {
            throw new NotImplementedException();
        }

        public bool Delete(List<Address> dataList)
        {
            throw new NotImplementedException();
        }

        public IList<Address> Read()
        {
            throw new NotImplementedException();
        }

        public bool Update(Address oldData, Address newData)
        {
            throw new NotImplementedException();
        }
    }
}
