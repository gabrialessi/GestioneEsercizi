using GestioneEsercizi.DA.Models;
using System.Linq;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati della classe.
    /// </summary>
    public class AnnoDbRepository : DbDataRepository<AppDbContext, Anno>, IAnnoRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public AnnoDbRepository(AppDbContext ctx) : base(ctx) { }
        /// <summary>
        /// Ritorna tutte le entità ordinate per anno.
        /// </summary>
        /// <returns>Le entità ordinate per anno.</returns>
        public override IQueryable<Anno> Get() => base.Get().OrderByDescending(s => s.Annata);
    }
}