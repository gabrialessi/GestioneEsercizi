using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati dell'esercizio.
    /// </summary>
    public class EsercizioDbRepository : DbDataRepository<AppDbContext, Esercizio>, IEsercizioRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public EsercizioDbRepository(AppDbContext ctx) : base(ctx)
        {
        }

        /// <summary>
        /// Ritorna tutte le entità ordinate per titolo.
        /// </summary>
        /// <returns>Le entità ordinate per titolo.</returns>
        public override IQueryable<Esercizio> Get()
        {
            return base.Get().OrderBy(s => s.Titolo);
        }
    }
}
