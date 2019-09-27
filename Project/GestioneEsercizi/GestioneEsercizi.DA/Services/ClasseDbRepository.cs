using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    public class ClasseDbRepository : DbDataRepository<AppDbContext, Classe>, IClasseRepository
    {
        public ClasseDbRepository(AppDbContext ctx) : base(ctx)
        {

        }
    }
}
