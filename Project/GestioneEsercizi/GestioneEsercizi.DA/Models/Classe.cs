using System;
using System.Collections.Generic;
using System.Text;

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
        public Anno Anno { get; set; }
    }
}
