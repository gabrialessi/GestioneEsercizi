using System;
using System.Collections.Generic;
using System.Text;

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

        public override string ToString()
        {
            return Nome;
        }
    }
}
