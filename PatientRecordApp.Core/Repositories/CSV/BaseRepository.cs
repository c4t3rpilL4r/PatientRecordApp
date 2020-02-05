using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PatientRecordApp.Core.Repositories.CSV
{
    public abstract class BaseRepository<T>
    {
        protected abstract string FilePath { get; }
        protected abstract IList<T> DataList { get; }

        public bool WriteIntoCSVFile()
        {
            try
            {
                var stringBuilder = new StringBuilder();

                foreach (T listData in DataList)
                {
                    var value = listData.GetType().GetProperties().Select(x => x.GetValue(listData)).ToString();

                    var data = string.Join(",", value);

                    stringBuilder.Append(data);
                }

                using (StreamWriter streamWriter = new StreamWriter(FilePath))
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
