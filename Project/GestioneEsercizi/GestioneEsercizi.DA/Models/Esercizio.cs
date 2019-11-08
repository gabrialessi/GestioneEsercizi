using System.Collections.Generic;

namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati dell'esercizio.
    /// </summary>
    public class Esercizio : BaseEntity
    {
        /// <summary>
        /// Titolo dell'esercizio.
        /// </summary>
        public string Titolo { get; set; }
        /// <summary>
        /// Testo dell'esercizio (include l'immagine).
        /// </summary>
        public string Testo { get; set; }
        /// <summary>
        /// Modulo relativo all'esercizio.
        /// </summary>
        public Modulo Modulo { get; set; }
        /// <summary>
        /// Esercizi della prova relativi all'esercizio.
        /// </summary>
        public ICollection<EsercizioProva> EserciziProva { get; set; }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il titolo dell'esercizio.</returns>
        public override string ToString() => Titolo;
    }
}