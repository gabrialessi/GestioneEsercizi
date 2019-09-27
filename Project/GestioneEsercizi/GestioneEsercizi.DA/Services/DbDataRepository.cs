using GestioneEsercizi.DA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    public abstract class DbDataRepository<C, T> : IDataRepository<T> where T : BaseEntity
                                                                      where C : DbContext, new()
    {
        protected C context;

        protected DbDataRepository(C ctx)
        {
            context = ctx;
        }

        public T Get(int id)
        {
            return Get().SingleOrDefault(be => be.Id == id);
        }

        public virtual IQueryable<T> Get()
        {
            return context.Set<T>();
        }

        public virtual T Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public virtual void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public virtual IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }
    }
}
