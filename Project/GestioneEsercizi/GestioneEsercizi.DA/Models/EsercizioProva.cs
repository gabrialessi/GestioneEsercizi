using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati dell'esercizio della prova.
    /// </summary>
    public class EsercizioProva : Esercizio
    {
        /// <summary>
        /// Esercizio relativo all'esercizio della prova.
        /// </summary>
        public Esercizio Esercizio { get; set; }
        /// <summary>
        /// Prova relativa all'esercizio della prova.
        /// </summary>
        public Prova Prova { get; set; }
        /// <summary>
        /// Stampa dell'oggetto (titolo).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Esercizio.Titolo;
        }
    }
}
