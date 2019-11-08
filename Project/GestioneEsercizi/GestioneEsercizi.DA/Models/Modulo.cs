using System.Collections.Generic;

namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati del modulo.
    /// </summary>
    public class Modulo : BaseEntity
    {
        /// <summary>
        /// Nome del modulo (esempio: "Modulo 151").
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Anno del modulo.
        /// </summary>
        public Anno Anno { get; set; }
        /// <summary>
        /// Insieme delle tematiche del modulo.
        /// </summary>
        public ICollection<Tematica> Tematiche { get; set; }
        /// <summary>
        /// Insieme degli esercizi del modulo.
        /// </summary>
        public ICollection<Esercizio> Esercizi { get; set; }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il nome del modulo.</returns>
        public override string ToString() => Nome;
    }
}