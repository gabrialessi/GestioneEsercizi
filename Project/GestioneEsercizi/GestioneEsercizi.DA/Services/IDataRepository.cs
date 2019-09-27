using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    public interface IDataRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IQueryable<T> Get();
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
