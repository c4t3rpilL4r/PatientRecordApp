﻿using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace PatientRecordApp.Core.Repositories.CSV
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        protected override string FilePath => ConfigurationManager.AppSettings["PatientCSVPath"];
        protected override IList<Patient> DataList => _patientList;

        private static IList<Patient> _patientList = new List<Patient>();

        public bool Create(Patient data)
        {
            _patientList.Add(data);

            return WriteIntoCSVFile();
        }

        public bool Delete(List<Patient> dataList)
        {
            dataList.ForEach(tobeRemove =>
            {
                _patientList.Remove(_patientList.FirstOrDefault(patient => patient.Id == tobeRemove.Id));
            });

            return WriteIntoCSVFile();
        }

        public IList<Patient> Read()
        {
            if (_patientList.Count == 0)
            {
                var patientData = File.ReadAllLines(FilePath);

                foreach (var line in patientData)
                {
                    var patient = line.Split(',');

                    _patientList.Add(new Patient()
                    {
                        Id = int.Parse(patient[0]),
                        Surname = patient[1],
                        FirstName = patient[2],
                        Gender = patient[3],
                        Age = int.Parse(patient[4]),
                        ContactNumber = int.Parse(patient[5]),
                        EmailAddress = patient[6],
                        AddressId = int.Parse(patient[7]),
                        DateOfConsultation = DateTime.Parse(patient[8]),
                        Diagnosis = patient[9],
                        DoctorId = int.Parse(patient[10])
                    });
                }
            }

            return _patientList;
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

        public bool Update(Patient oldData, Patient newData)
        {
            _patientList.Remove(_patientList.FirstOrDefault(patient => patient.Id == oldData.Id));

            _patientList.Add(newData);

            return WriteIntoCSVFile();
        }
    }
}