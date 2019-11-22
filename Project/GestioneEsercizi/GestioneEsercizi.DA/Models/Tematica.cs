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
        /// Metodo costruttore vuoto.
        /// </summary>
        public Tematica() { }
        /// <summary>
        /// Metodo costruttore della tematica.
        /// </summary>
        /// <param name="nome">Nome della tematica.</param>
        /// <param name="modulo">Modulo relativo alla tematica.</param>
        public Tematica(string nome, Modulo modulo)
        {
            Nome = nome;
            Modulo = modulo;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il nome della tematica.</returns>
        public override string ToString() => Nome;
    }
}