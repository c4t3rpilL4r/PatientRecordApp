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
        public int ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public int AddressId { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string Diagnosis { get; set; }
        public int DoctorId { get; set; }
    }
}
