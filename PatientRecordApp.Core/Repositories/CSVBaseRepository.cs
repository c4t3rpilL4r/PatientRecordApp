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
        private readonly string _filePath = ConfigurationManager.AppSettings["CSVPath"];
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
                var data = File.ReadAllLines(_filePath);

                foreach (var line in data)
                {
                    var patient = line.Split(',');

                    _patientList.Add(new Patient()
                    {
                        Surname = patient[0],
                        FirstName = patient[1],
                        Gender = patient[2],
                        DateOfConsultation = DateTime.Parse(patient[3]),
                        Diagnosis = patient[4],
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

                using (StreamWriter streamWriter = new StreamWriter(_filePath))
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
