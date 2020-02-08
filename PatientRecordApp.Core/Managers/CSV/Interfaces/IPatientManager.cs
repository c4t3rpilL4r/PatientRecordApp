using PatientRecordApp.Core.Models;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Managers.CSV.Interfaces
{
	public interface IPatientManager : IManager<Patient>
	{
		IList<Patient> Search(SearchFilters filters);
	}
}
