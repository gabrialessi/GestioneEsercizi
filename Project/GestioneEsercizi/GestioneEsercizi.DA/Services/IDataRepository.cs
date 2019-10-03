using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Interfaccia di base che implementa i metodi relativi alle 
    /// operazioni sui dati nel database.
    /// </summary>
    /// <typeparam name="T">Modello di dati di riferimento.</typeparam>
    public interface IDataRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Ritorna un'entità in base all'id passato.
        /// </summary>
        /// <param name="id">Id dell'entità da ricavare.</param>
        /// <returns>Entità in base all'id passato.</returns>
        T Get(int id);

        /// <summary>
        /// Ritorna tutte le entità.
        /// </summary>
        /// <returns>Tutte le entità del modello di dati in questione.</returns>
        IQueryable<T> Get();

        /// <summary>
        /// Inserisce una nuova entità.
        /// </summary>
        /// <param name="entity">Entità da inserire.</param>
        /// <returns>Entità appena inserita.</returns>
        T Insert(T entity);

        /// <summary>
        /// Modifica un'entità.
        /// </summary>
        /// <param name="entity">Entità da modificare.</param>
        void Update(T entity);

        /// <summary>
        /// Elimina un'entità.
        /// </summary>
        /// <param name="entity">Entità da eliminare.</param>
        void Delete(T entity);
    }
}
