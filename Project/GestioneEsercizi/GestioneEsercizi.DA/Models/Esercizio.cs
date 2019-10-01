using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    public class Esercizio : BaseEntity
    {
        public string Titolo { get; set; }
        public string Testo { get; set; }
    }
}
