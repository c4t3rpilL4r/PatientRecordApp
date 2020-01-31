using System;

namespace PatientRecordApp.Core.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string Diagnosis { get; set; }
        public Doctor Doctor { get; set; }
    }
}
