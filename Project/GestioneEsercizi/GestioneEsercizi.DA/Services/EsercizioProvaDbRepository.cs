using GestioneEsercizi.DA.Models;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati dell'EsercizioProva.
    /// </summary>
    public class EsercizioProvaDbRepository : DbDataRepository<AppDbContext, EsercizioProva>, IEsercizioProvaRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public EsercizioProvaDbRepository(AppDbContext ctx) : base(ctx) { }
    }
}