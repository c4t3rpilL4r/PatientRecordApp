using System.Collections.Generic;

namespace PatientRecordApp.Core.Managers.CSV.Interfaces
{
	public interface IManager<T>
	{
		bool Create(T data);
		IList<T> Read();
		bool Update(T oldData, T newData);
		bool Delete(List<int> dataList);
		T FindById(int id);
	}
}
