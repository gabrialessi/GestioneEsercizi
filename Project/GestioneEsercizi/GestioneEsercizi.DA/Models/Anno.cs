using System.Collections.Generic;

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
        public virtual ICollection<Classe> Classi { get; set; }
        /// <summary>
        /// Insieme dei moduli dell'anno.
        /// </summary>
        public virtual ICollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Insieme delle prove dell'anno.
        /// </summary>
        public virtual ICollection<Prova> Prove { get; set; }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>L'annata dell'oggetto.</returns>
        public override string ToString() => Annata;
    }
}