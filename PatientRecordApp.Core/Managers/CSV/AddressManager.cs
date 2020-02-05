using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;

namespace PatientRecordApp.Core.Managers.CSV
{
    public class AddressManager : BaseManager<Address>, IAddressManager
    {
        protected override IRepository<Address> Repository => new AddressRepository();
    }
}
