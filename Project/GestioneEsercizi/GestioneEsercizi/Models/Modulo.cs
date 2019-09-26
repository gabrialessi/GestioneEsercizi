using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsercizi.Models
{
    public class Modulo : ImpostazioneDiBase
    {
        public Anno Anno { get; set; }
        public ICollection<Tematica> Tematiche { get; set; }
    }
}
