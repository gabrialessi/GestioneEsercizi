using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_RSI.DA.Service
{
    public interface IDataRepository<T>
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Delete(T entity);
        T Insert(T entity);
        int Update(T entity);
    }
}
