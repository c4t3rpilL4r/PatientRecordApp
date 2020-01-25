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
        private readonly string filePath = ConfigurationManager.AppSettings["CSVPath"];
        private static IList<Patient> patientList = new List<Patient>();

        public bool Create(Patient patient)
        {
            patientList.Add(patient);

            return WriteIntoCSVFile();
        }

        public IList<Patient> Read()
        {
            if (patientList.Count == 0)
            {
                var data = File.ReadAllLines(filePath);

                foreach (var line in data)
                {
                    var patient = line.Split(',');

                    patientList.Add(new Patient()
                    {
                        Surname = patient[0],
                        FirstName = patient[1],
                        Gender = patient[2],
                        DateOfConsultation = DateTime.Parse(patient[3]),
                        Diagnosis = patient[4],
                    });
                }
            }

            return patientList;
        }

        public bool Update(Patient oldPatientRecord, Patient newPatientRecord)
        {
            patientList.Remove(patientList.FirstOrDefault(patient => patient.isEqual(oldPatientRecord)));

            patientList.Add(newPatientRecord);

            return WriteIntoCSVFile();
        }

        public bool Delete(List<Patient> patients)
        {
            patients.ForEach(tobeRemove =>
            {
                patientList.Remove(patientList.FirstOrDefault(patient => patient.isEqual(tobeRemove)));
            });

            return WriteIntoCSVFile();
        }

        private bool WriteIntoCSVFile()
        {
            try
            {
                var stringBuilder = new StringBuilder();

                foreach (Patient patient in patientList)
                {
                    string[] value = { patient.Surname, patient.FirstName, patient.Gender, patient.DateOfConsultation.ToString(), patient.Diagnosis, Environment.NewLine };

                    var data = string.Join(",", value);

                    stringBuilder.Append(data);
                }

                using (StreamWriter streamWriter = new StreamWriter(filePath))
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
