using System.Collections.Generic;

namespace GestioneEsercizi.DA.Models
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
        /// Insieme dei moduli della classe.
        /// </summary>
        public virtual ICollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Insieme delle prove della classe.
        /// </summary>
        public virtual ICollection<Prova> Prove { get; set; }
        /// <summary>
        /// Metodo costruttore vuoto.
        /// </summary>
        public Classe() { }
        /// <summary>
        /// Metodo costruttore della classe.
        /// </summary>
        /// <param name="nome">Nome della classe.</param>
        /// <param name="anno">Anno della classe.</param>
        public Classe(string nome, Anno anno)
        {
            Nome = nome;
            Anno = anno;
        }
        /// <summary>
        /// Stampa dell'oggetto.
        /// </summary>
        /// <returns>Il nome della classe.</returns>
        public override string ToString() => Nome;
    }
}