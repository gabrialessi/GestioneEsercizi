using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    public class Classe : BaseEntity
    {
        public string Nome { get; set; }
        public Anno Anno { get; set; }
    }
}
