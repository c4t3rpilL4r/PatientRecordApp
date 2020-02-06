using PatientRecordApp.Core.Models;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Repositories.CSV.Interfaces
{
	public interface IPatientRepository : IRepository<Patient>
	{
		IList<Patient> Search(SearchFilters filters);
	}
}
