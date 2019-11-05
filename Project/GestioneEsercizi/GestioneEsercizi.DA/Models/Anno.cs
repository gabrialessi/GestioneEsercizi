using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati dell'anno.
    /// </summary>
    public class Anno : BaseEntity
    {
        /// <summary>
        /// Annata (esempio: "2019/2020").
        /// </summary>
        public string Annata { get; set; }
        /// <summary>
        /// Insieme delle classi dell'anno.
        /// </summary>
        public ICollection<Classe> Classi { get; set; }
        /// <summary>
        /// Insieme dei moduli dell'anno.
        /// </summary>
        public ICollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Insieme delle prove dell'anno.
        /// </summary>
        public ICollection<Prova> Prove { get; set; }

        public override string ToString()
        {
            return Annata;
        }
    }
}
