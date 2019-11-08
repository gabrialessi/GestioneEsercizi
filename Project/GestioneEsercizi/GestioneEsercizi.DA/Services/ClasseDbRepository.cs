using GestioneEsercizi.DA.Models;
using System.Linq;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati della classe.
    /// </summary>
    public class ClasseDbRepository : DbDataRepository<AppDbContext, Classe>, IClasseRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public ClasseDbRepository(AppDbContext ctx) : base(ctx) { }
        /// <summary>
        /// Ritorna tutte le entità ordinate per anno.
        /// </summary>
        /// <returns>Le entità ordinate per anno.</returns>
        public override IQueryable<Classe> Get() => base.Get().OrderBy(s => s.Anno);
    }
}