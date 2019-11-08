using GestioneEsercizi.DA.Models;
using System.Linq;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati della prova.
    /// </summary>
    public class ProvaDbRepository : DbDataRepository<AppDbContext, Prova>, IProvaRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public ProvaDbRepository(AppDbContext ctx) : base(ctx) { }
        /// <summary>
        /// Ritorna tutte le entità ordinate per data.
        /// </summary>
        /// <returns>Le entità ordinate per data.</returns>
        public override IQueryable<Prova> Get() => base.Get().OrderBy(s => s.Data);
    }
}