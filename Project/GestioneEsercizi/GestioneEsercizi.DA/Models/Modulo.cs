using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
        /// Classe del modulo.
        /// </summary>
        public virtual Classe Classe { get; set; }
        /// <summary>
        /// Classe del modulo (FK).
        /// </summary>
        public int ClasseId { get; set; }
        /// <summary>
        /// Insieme delle tematiche del modulo.
        /// </summary>
        public virtual ICollection<Tematica> Tematiche { get; set; }
        /// <summary>
        /// Lista non salvata nel DB delle tematiche sotto forma di stringa.
        /// </summary>
        [NotMapped]
        public string TematicheList => string.Join(", ", Tematiche);
        /// <summary>
        /// Insieme degli esercizi del modulo.
        /// </summary>
        public virtual ICollection<Esercizio> Esercizi { get; set; }
        /// <summary>
        /// Lista non salvata nel DB degli esercizi sotto forma di stringa.
        /// </summary>
        [NotMapped]
        public string EserciziList => string.Join(", ", Esercizi);
        /// <summary>
        /// Metodo costruttore vuoto.
        /// </summary>
        public Modulo() { }
        /// <summary>
        /// Metodo costruttore del modulo.
        /// </summary>
        /// <param name="nome">Nome del modulo</param>
        /// <param name="classe">Classe del modulo.</param>
        public Modulo(string nome, Classe classe)
        {
            Nome = nome;
            ClasseId = classe.Id;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il nome del modulo.</returns>
        public override string ToString() => Nome;
    }
}