using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace PatientRecordApp.Core.Repositories.CSV
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        protected override string FilePath => ConfigurationManager.AppSettings["PatientCSVPath"];
        protected override IList<Address> DataList => _addressList;

        private static IList<Address> _addressList = new List<Address>();

        public bool Create(Address data)
        {
            _addressList.Add(data);

            return WriteIntoCSVFile();
        }

        public bool Delete(List<Address> dataList)
        {
            dataList.ForEach(tobeRemove =>
            {
                _addressList.Remove(_addressList.FirstOrDefault(address => address.Id == tobeRemove.Id));
            });

            return WriteIntoCSVFile();
        }

        public IList<Address> Read()
        {
            if (_addressList.Count == 0)
            {
                var addressData = File.ReadAllLines(FilePath);

                foreach (var line in addressData)
                {
                    var address = line.Split(',');

                    _addressList.Add(new Address()
                    {
                        Id = int.Parse(address[0]),
                        Address1 = address[1],
                        Address2 = address[2],
                        City = address[3],
                        Province = address[4],
                        Country = address[5],
                        ZipCode = int.Parse(address[6])
                    });
                }
            }

            return _addressList;
        }

        public bool Update(Address oldData, Address newData)
        {
            _addressList.Remove(_addressList.FirstOrDefault(address => address.Id == oldData.Id));

            _addressList.Add(newData);

            return WriteIntoCSVFile();
        }
    }
}
