using System;

namespace PatientRecordApp.Core.Models
{
    public class Patient
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string Diagnosis { get; set; }

        public bool isEqual(Patient patient)
        {
            var isTheSame = false;

            if (Surname.Equals(patient.Surname)
                && FirstName.Equals(patient.FirstName)
                && Gender.Equals(patient.Gender)
                && DateOfConsultation.ToString().Equals(patient.DateOfConsultation.ToString())
                && Diagnosis.Equals(patient.Diagnosis))
            {
                isTheSame = true;
            }

            return isTheSame;
        }
    }
}
