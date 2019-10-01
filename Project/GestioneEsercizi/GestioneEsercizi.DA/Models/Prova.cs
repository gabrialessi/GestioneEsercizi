using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    public class Prova : BaseEntity
    {
        public string Titolo { get; set; }
        public DateTime Data { get; set; }
        public ICollection<EsercizioProva> EserciziProva { get; set; }
    }
}
