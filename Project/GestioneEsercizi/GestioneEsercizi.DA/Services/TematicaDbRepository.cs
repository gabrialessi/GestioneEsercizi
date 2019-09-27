using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    public class TematicaDbRepository : DbDataRepository<AppDbContext, Tematica>, ITematicaRepository
    {
        public TematicaDbRepository(AppDbContext ctx) : base(ctx)
        {

        }
    }
}
