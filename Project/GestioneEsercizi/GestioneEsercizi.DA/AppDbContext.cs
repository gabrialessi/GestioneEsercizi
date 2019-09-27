using GestioneEsercizi.DA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneEsercizi.DA
{
    public class AppDbContext : DbContext
    {
        public DbSet<Classe> Classi { get; set; }

        public DbSet<Modulo> Moduli { get; set; }

        public DbSet<Tematica> Tematiche { get; set; }

        public AppDbContext() : base()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=D:\\Temp\\GestioneEsercizi.db");
            }
        }
    }
}
