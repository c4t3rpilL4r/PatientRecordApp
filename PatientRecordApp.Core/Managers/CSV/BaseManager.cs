using PatientRecordApp.Core.Managers.CSV.Interfaces;
using PatientRecordApp.Core.Repositories.CSV.Interfaces;
using System.Collections.Generic;

namespace PatientRecordApp.Core.Managers
{
	public abstract class BaseManager<T> : IManager<T>
	{
		protected abstract IRepository<T> Repository { get; }

		public bool Create(T data)
		{
			return Repository.Create(data);
		}

		public bool Delete(List<int> dataList)
		{
			return Repository.Delete(dataList);
		}

		public T FindById(int id)
		{
			return Repository.FindById(id);
		}

		public IList<T> Read()
		{
			return Repository.Read();
		}

		public bool Update(T oldData, T newData)
		{
			return Repository.Update(oldData, newData);
		}
	}
}
