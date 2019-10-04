using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati del modulo.
    /// </summary>
    public class ModuloDbRepository : DbDataRepository<AppDbContext, Modulo>, IModuloRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public ModuloDbRepository(AppDbContext ctx) : base(ctx)
        {
        }

        /// <summary>
        /// Ritorna tutte le entità ordinate per nome.
        /// </summary>
        /// <returns>Le entità ordinate per nome.</returns>
        public override IQueryable<Modulo> Get()
        {
            return base.Get().OrderBy(s => s.Nome);
        }
    }
}
