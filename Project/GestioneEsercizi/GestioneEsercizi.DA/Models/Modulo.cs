﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Models
{
    public class Modulo : BaseEntity
    {
        public string Nome { get; set; }
        public Anno Anno { get; set; }
        public ICollection<Tematica> Tematiche { get; set; }
        public ICollection<Esercizio> Esercizi { get; set; }
    }
}
