using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati della prova.
    /// </summary>
    public class Prova : BaseEntity
    {
        /// <summary>
        /// Titolo della prova.
        /// </summary>
        public string Titolo { get; set; }
        /// <summary>
        /// Data della prova.
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Anno della prova.
        /// </summary>
        public Anno Anno { get; set; }
        /// <summary>
        /// Insieme degli esercizi della prova.
        /// </summary>
        public ICollection<EsercizioProva> EserciziProva { get; set; }
        /// <summary>
        /// Stampa dell'oggetto (titolo).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Titolo;
        }
    }
}
