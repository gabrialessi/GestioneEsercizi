namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati dell'esercizio della prova.
    /// </summary>
    public class EsercizioProva : BaseEntity
    {
        /// <summary>
        /// Esercizio relativo all'esercizio della prova.
        /// </summary>
        public virtual Esercizio Esercizio { get; set; }
        /// <summary>
        /// Prova relativa all'esercizio della prova.
        /// </summary>
        public virtual Prova Prova { get; set; }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il titolo dell'esercizio.</returns>
        public override string ToString() => Esercizio.Titolo;
    }
}