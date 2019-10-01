using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    public class Anno : BaseEntity
    {
        public string Annata { get; set; }
        public ICollection<Classe> Classi { get; set; }
        public ICollection<Modulo> Moduli { get; set; }
        public ICollection<Prova> Prove { get; set; }
    }
}
