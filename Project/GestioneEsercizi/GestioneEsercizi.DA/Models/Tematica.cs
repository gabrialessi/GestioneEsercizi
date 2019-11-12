namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati della tematica.
    /// </summary>
    public class Tematica : BaseEntity
    {
        /// <summary>
        /// Nome della tematica.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Modulo relativo alla tematica.
        /// </summary>
        public virtual Modulo Modulo { get; set; }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il nome della tematica.</returns>
        public override string ToString() => Nome;
    }
}