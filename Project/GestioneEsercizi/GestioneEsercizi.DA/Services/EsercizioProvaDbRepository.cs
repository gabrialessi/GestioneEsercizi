﻿using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    /// <summary>
    /// Deposito dati relativo al modello di dati dell'esercizio della prova.
    /// </summary>
    public class EsercizioProvaDbRepository : DbDataRepository<AppDbContext, EsercizioProva>, IEsercizioProvaRepository
    {
        /// <summary>
        /// Metodo costruttore, si definisce il contesto di dati.
        /// </summary>
        /// <param name="ctx">Contesto di dati del database.</param>
        public EsercizioProvaDbRepository(AppDbContext ctx) : base(ctx)
        {
        }

        /// <summary>
        /// Ritorna tutte le entità ordinate per titolo.
        /// </summary>
        /// <returns>Le entità ordinate per titolo.</returns>
        public override IQueryable<EsercizioProva> Get()
        {
            return base.Get().OrderBy(s => s.Titolo);
        }
    }
}