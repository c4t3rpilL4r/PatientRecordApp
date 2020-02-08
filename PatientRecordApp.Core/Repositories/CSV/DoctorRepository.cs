using PatientRecordApp.Core.Constants;
using PatientRecordApp.Core.Models;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace PatientRecordApp.Core.Repositories.CSV
{
	public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
	{
		protected override string FilePath => XDocument.Load(Path.Combine(Directory.GetCurrentDirectory(), "settings.xml"))
			.Element(SettingsXMLElement.SETTINGS)
			.Element(SettingsXMLElement.FILEPATH)
			.Element(SettingsXMLElement.DOCTORCSV)
			.Value;
		protected override IList<Doctor> DataList => _doctorList;

		private static IList<Doctor> _doctorList = new List<Doctor>();

		public DoctorRepository()
		{
			_doctorList = Read();
		}

		public bool Create(Doctor data)
		{
			_doctorList.Add(data);

			return WriteIntoCSVFile();
		}

		public bool Delete(List<Doctor> dataList)
		{
			dataList.ForEach(tobeRemove =>
			{
				_doctorList.Remove(_doctorList.FirstOrDefault(doctor => doctor.Id == tobeRemove.Id));
			});

			return WriteIntoCSVFile();
		}

		public IList<Doctor> Read()
		{
			if (_doctorList.Count == 0)
			{
				var doctorData = File.ReadAllLines(FilePath);

				foreach (var line in doctorData)
				{
					var doctor = line.Split(',');

					_doctorList.Add(new Doctor()
					{
						Id = int.Parse(doctor[0]),
						FirstName = doctor[1],
						LastName = doctor[2],
						Department = doctor[3]
					});
				}
			}

			return _doctorList;
		}

		public bool Update(Doctor oldData, Doctor newData)
		{
			_doctorList.Remove(_doctorList.FirstOrDefault(doctor => doctor.Id == oldData.Id));

			_doctorList.Add(newData);

			return WriteIntoCSVFile();
		}
	}
}
