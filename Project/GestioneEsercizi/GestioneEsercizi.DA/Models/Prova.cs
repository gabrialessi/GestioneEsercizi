using System;
using System.Collections.Generic;

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
        public virtual Anno Anno { get; set; }
        /// <summary>
        /// Insieme degli esercizi della prova.
        /// </summary>
        public virtual ICollection<EsercizioProva> EserciziProva { get; set; }
        /// <summary>
        /// Metodo costruttore vuoto.
        /// </summary>
        public Prova() { }
        /// <summary>
        /// Metodo costruttore della prova.
        /// </summary>
        /// <param name="titolo">Titolo della prova.</param>
        /// <param name="data">Data della prova.</param>
        /// <param name="anno">Anno della prova.</param>
        /// <param name="esercizi">Esercizi della prova.</param>
        public Prova(string titolo, DateTime data, Anno anno)
        {
            Titolo = titolo;
            Data = data;
            Anno = anno;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il titolo della prova.</returns>
        public override string ToString() => Titolo;
    }
}