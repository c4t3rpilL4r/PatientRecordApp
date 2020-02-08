using System;

namespace PatientRecordApp.Core.Models
{
	public class Patient
	{
		public int Id { get; set; }
		public string Surname { get; set; }
		public string FirstName { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }
		public int ZipCode { get; set; }
		public string ContactNumber { get; set; }
		public string EmailAddress { get; set; }
		public DateTime DateOfConsultation { get; set; }
		public string Diagnosis { get; set; }
		public int DoctorId { get; set; }
	}
}
