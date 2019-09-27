using GestioneEsercizi.DA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.DA.Services
{
    public class ModuloDbRepository : DbDataRepository<AppDbContext, Modulo>, IModuloRepository
    {
        public ModuloDbRepository(AppDbContext ctx) : base(ctx)
        {

        }
    }
}
