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
        /// Classe della prova.
        /// </summary>
        public virtual Classe Classe { get; set; }
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
        /// <param name="classe">Classe della prova.</param>
        /// <param name="esercizi">Esercizi della prova.</param>
        public Prova(string titolo, DateTime data, Classe classe)
        {
            Titolo = titolo;
            Data = data;
            Classe = classe;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il titolo della prova.</returns>
        public override string ToString() => Titolo;
    }
}