using System.Collections.Generic;

namespace PatientRecordApp.Core.Repositories.CSV.Interfaces
{
    public interface IRepository<T>
    {
        bool Create(T data);
        IList<T> Read();
        bool Update(T oldData, T newData);
        bool Delete(List<int> dataList);
        T FindById(int id);
    }
}
