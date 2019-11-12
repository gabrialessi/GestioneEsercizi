﻿namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati della classe.
    /// </summary>
    public class Classe : BaseEntity
    {
        /// <summary>
        /// Nome della classe (esempio: "I4AA").
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Anno della classe.
        /// </summary>
        public virtual Anno Anno { get; set; }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il nome della classe.</returns>
        public override string ToString() => Nome;
    }
}