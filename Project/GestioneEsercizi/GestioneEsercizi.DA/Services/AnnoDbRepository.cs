using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati dell'anno.
    /// </summary>
    public class AnnoDbRepository : DbDataRepository<AppDbContext, Anno>, IAnnoRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public AnnoDbRepository(AppDbContext ctx) : base(ctx)
        {
        }

        /// <summary>
        /// Ritorna tutte le entità ordinate per annata.
        /// </summary>
        /// <returns>Le entità ordinate per annata.</returns>
        public override IQueryable<Anno> Get()
        {
            return base.Get().OrderBy(s => s.Annata);
        }
    }
}
