using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace PatientRecordApp.Core.Repositories
{
    internal class CSVBaseRepository : ICSVRepository
    {
        private readonly string _patientFilePath = ConfigurationManager.AppSettings["PatientCSVPath"];
        private readonly string _doctorFilePath = ConfigurationManager.AppSettings["PatientCSVPath"];
        private readonly string _addressFilePath = ConfigurationManager.AppSettings["PatientCSVPath"];
        private static IList<Patient> _patientList = new List<Patient>();

        public bool Create(Patient patient)
        {
            _patientList.Add(patient);

            return WriteIntoCSVFile();
        }

        public IList<Patient> Read()
        {
            if (_patientList.Count == 0)
            {
                var doctor = new Doctor();
                var address = new Address();

                var patientData = File.ReadAllLines(_patientFilePath);
                var doctorData = File.ReadAllLines(_doctorFilePath);
                var addressData = File.ReadAllLines(_addressFilePath);
                
                foreach (var lineInPatientData in patientData)
                {
                    var patientArray = lineInPatientData.Split(',');

                    foreach (var lineInAddressData in addressData)
                    {
                        var addressArray = lineInAddressData.Split(',');

                        if (int.Parse(addressArray[0]) == int.Parse(patientArray[6]))
                        {
                            address.Address1 = addressArray[1];
                            address.Address2 = addressArray[2];
                            address.City = addressArray[3];
                            address.Province = addressArray[4];
                            address.Country = addressArray[5];
                            address.ZipCode = int.Parse(addressArray[6]);
                            break;
                        }
                    }

                    foreach (var lineInDoctorData in doctorData)
                    {
                        var doctorArray = lineInDoctorData.Split(',');

                        if (int.Parse(doctorArray[0]) == int.Parse(patientArray[9]))
                        {
                            doctor.FirstName = doctorArray[1];
                            doctor.LastName = doctorArray[2];
                            doctor.Department = doctorArray[3];
                            break;
                        }
                    }

                    _patientList.Add(new Patient()
                    {
                        Id = int.Parse(patientArray[0]),
                        Surname = patientArray[1],
                        FirstName = patientArray[2],
                        Gender = patientArray[3],
                        MobileNumber = int.Parse(patientArray[4]),
                        EmailAddress = patientArray[5],
                        Address = new Address()
                        {
                            Address1 = address.Address1,
                            Address2 = address.Address2,
                            City = address.City,
                            Province = address.Province,
                            Country = address.Country,
                            ZipCode = address.ZipCode
                        },
                        DateOfConsultation = DateTime.Parse(patientArray[12]),
                        Diagnosis = patientArray[13],
                        Doctor = new Doctor()
                        {
                            FirstName = doctor.FirstName,
                            LastName = doctor.LastName,
                            Department = doctor.Department
                        }
                    });
                }
            }

            return _patientList;
        }

        public bool Update(Patient oldPatientRecord, Patient newPatientRecord)
        {
            _patientList.Remove(_patientList.FirstOrDefault(patient => patient.Id == oldPatientRecord.Id));

            _patientList.Add(newPatientRecord);

            return WriteIntoCSVFile();
        }

        public bool Delete(List<Patient> patients)
        {
            patients.ForEach(tobeRemove =>
            {
                _patientList.Remove(_patientList.FirstOrDefault(patient => patient.Id == tobeRemove.Id));
            });

            return WriteIntoCSVFile();
        }

        public IList<Patient> Search(SearchFilters filters)
        {
            var patientList = _patientList;
            var searchList = new List<Patient>();

            if (!string.IsNullOrWhiteSpace(filters.FullName))
            {
                foreach (Patient patient in patientList)
                {
                    var counter = 0;
                    var nameSplit = filters.FullName.Split(' ');
                    var fullName = $"{patient.FirstName} {patient.Surname}";

                    foreach (var split in nameSplit)
                    {
                        while (fullName.ToLower().Contains(split.ToLower()))
                        {
                            counter++;
                            break;
                        }

                        if (counter == nameSplit.Length)
                        {
                            searchList.Add(patient);
                        }
                    }
                }

                patientList = searchList;
                searchList = new List<Patient>();
            }

            if (!string.IsNullOrWhiteSpace(filters.Gender))
            {
                foreach (Patient patient in patientList)
                {
                    if (patient.Gender.Equals(filters.Gender))
                    {
                        searchList.Add(patient);
                    }
                }

                patientList = searchList;
                searchList = new List<Patient>();
            }

            if (!string.IsNullOrWhiteSpace(filters.DateOfConsultation))
            {
                foreach (Patient patient in patientList)
                {
                    if (patient.DateOfConsultation.Date.ToString().Contains(filters.DateOfConsultation))
                    {
                        searchList.Add(patient);
                    }
                }

                patientList = searchList;
                searchList = new List<Patient>();
            }

            if (!string.IsNullOrWhiteSpace(filters.Diagnosis))
            {
                foreach (Patient patient in patientList)
                {
                    if (patient.Diagnosis.Equals(filters.Diagnosis))
                    {
                        searchList.Add(patient);
                    }
                }

                patientList = searchList;
                searchList = new List<Patient>();
            }

            return patientList;
        }

        private bool WriteIntoCSVFile()
        {
            try
            {
                var stringBuilder = new StringBuilder();

                foreach (Patient patient in _patientList)
                {
                    string[] value = { patient.Surname, patient.FirstName, patient.Gender, patient.DateOfConsultation.ToString(), patient.Diagnosis, Environment.NewLine };

                    var data = string.Join(",", value);

                    stringBuilder.Append(data);
                }

                using (StreamWriter streamWriter = new StreamWriter(_patientFilePath))
                {
                    streamWriter.Write(stringBuilder);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
