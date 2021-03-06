﻿namespace GestioneEsercizi.DA.Models
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
        /// FK dell'esercizio prova.
        /// </summary>
        public int EsercizioId { get; set; }
        /// <summary>
        /// Prova relativa all'esercizio della prova.
        /// </summary>
        public virtual Prova Prova { get; set; }
        /// <summary>
        /// FK della prova.
        /// </summary>
        public int ProvaId { get; set; }
        /// <summary>
        /// Metodo costruttore vuoto.
        /// </summary>
        public EsercizioProva() { }
        /// <summary>
        /// Metodo costruttore dell'esercizio della prova.
        /// </summary>
        /// <param name="esercizio">Esercizio relativo all'esercizio della prova.</param>
        /// <param name="prova">Prova relativa all'esercizio della prova.</param>
        public EsercizioProva(Esercizio esercizio, Prova prova)
        {
            EsercizioId = esercizio.Id;
            ProvaId = prova.Id;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il titolo dell'esercizio.</returns>
        public override string ToString() => Esercizio.ToString();
    }
}