using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Managers.CSV
{
	public class PatientManager : BaseManager<Patient>, IPatientManager
	{
		protected override IRepository<Patient> Repository => new PatientRepository();

		public IList<Patient> Search(SearchFilters filters)
		{
			return ((IPatientRepository)Repository).Search(filters);
		}
	}
}
