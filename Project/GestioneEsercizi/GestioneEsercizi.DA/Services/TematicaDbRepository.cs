using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati della tematica.
    /// </summary>
    public class TematicaDbRepository : DbDataRepository<AppDbContext, Tematica>, ITematicaRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public TematicaDbRepository(AppDbContext ctx) : base(ctx)
        {
        }

        /// <summary>
        /// Ritorna tutte le entità ordinate per nome.
        /// </summary>
        /// <returns>Le entità ordinate per nome.</returns>
        public override IQueryable<Tematica> Get()
        {
            return base.Get().OrderBy(s => s.Modulo);
        }
    }
}
