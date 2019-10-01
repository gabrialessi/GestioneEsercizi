using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    public class EsercizioProva : Esercizio
    {
        public Esercizio Esercizio { get; set; }
        public Prova Prova { get; set; }
    }
}
