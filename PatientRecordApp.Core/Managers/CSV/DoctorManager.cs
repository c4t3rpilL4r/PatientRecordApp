using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;

namespace PatientRecordApp.Core.Managers.CSV
{
	public class DoctorManager : BaseManager<Doctor>, IDoctorManager
	{
		protected override IRepository<Doctor> Repository => new DoctorRepository();
	}
}
