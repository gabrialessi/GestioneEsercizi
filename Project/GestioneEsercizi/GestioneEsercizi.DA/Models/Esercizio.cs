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
        public virtual Modulo Modulo { get; set; }
        /// <summary>
        /// Esercizi della prova relativi all'esercizio.
        /// </summary>
        public virtual ICollection<EsercizioProva> EserciziProva { get; set; }
        /// <summary>
        /// Metodo costruttore vuoto.
        /// </summary>
        public Esercizio() { }
        /// <summary>
        /// Metodo costruttore della classe.
        /// </summary>
        /// <param name="titolo">Titolo dell'esercizio.</param>
        /// <param name="testo">Testo dell'esercizio.</param>
        /// <param name="modulo">Modulo dell'esercizio.</param>
        public Esercizio(string titolo, string testo, Modulo modulo)
        {
            Titolo = titolo;
            Testo = testo;
            Modulo = modulo;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il titolo dell'esercizio.</returns>
        public override string ToString() => Titolo;
    }
}