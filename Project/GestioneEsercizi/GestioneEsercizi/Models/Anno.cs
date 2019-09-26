using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsercizi.Models
{
    public class Anno : BaseEntity
    {
        public string Annata { get; set; }
        public ICollection<Classe> Classi { get; set; }
        public ICollection<Modulo> Moduli { get; set; }
    }
}
