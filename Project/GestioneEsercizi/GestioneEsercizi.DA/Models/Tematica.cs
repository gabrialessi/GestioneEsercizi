using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    /// <summary>
    /// Modello di dati della tematica.
    /// </summary>
    public class Tematica : BaseEntity
    {
        /// <summary>
        /// Nome della tematica.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Modulo relativo alla tematica.
        /// </summary>
        public Modulo Modulo { get; set; }
    }
}
