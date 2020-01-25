using PatientRecordApp.Core.Models;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Repositories.Interfaces
{
	internal interface ICSVRepository
	{
		bool Create(Patient patient);
		IList<Patient> Read();
		bool Update(Patient oldPatientRecord, Patient newPatientRecord);
		bool Delete(List<Patient> patients);
		IList<Patient> RetrieveDataThroughSearchFilters(string name, string gender, string dateOfConsultation, string diagnosis);
	}
}
