using GestioneEsercizi.DA.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito di dati di base che implementa i metodi relativi al database.
    /// </summary>
    /// <typeparam name="C">Contesto di dati del database.</typeparam>
    /// <typeparam name="T">Modello di dati di riferimento.</typeparam>
    public abstract class DbDataRepository<C, T> : IDataRepository<T> where T : BaseEntity
                                                                      where C : DbContext, new()
    {
        /// <summary>
        /// Contesto di dati del database.
        /// </summary>
        protected C context;
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati del database.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        protected DbDataRepository(C ctx) => context = ctx;
        /// <summary>
        /// Ritorna un'entità in base all'id passato.
        /// </summary>
        /// <param name="id">Id dell'entità da ricavare.</param>
        /// <returns>Entità in base all'id passato.</returns>
        public T Get(int id) => Get().SingleOrDefault(be => be.Id == id);
        /// <summary>
        /// Ritorna tutte le entità.
        /// </summary>
        /// <returns>Tutte le entità del modello di dati in questione.</returns>
        public virtual IQueryable<T> Get() => context.Set<T>();
        /// <summary>
        /// Inserisce una nuova entità.
        /// </summary>
        /// <param name="entity">Entità da inserire.</param>
        /// <returns>Entità appena inserita.</returns>
        public virtual T Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }
        /// <summary>
        /// Modifica un'entità.
        /// </summary>
        /// <param name="entity">Entità da modificare.</param>
        public virtual void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        /// <summary>
        /// Elimina un'entità.
        /// </summary>
        /// <param name="entity">Entità da eliminare.</param>
        public virtual void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
    }
}