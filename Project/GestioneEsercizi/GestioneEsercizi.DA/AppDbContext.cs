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
    /// <summary>
    /// Classe che imposta le entità del database e configura
    /// il percorso di memorizzazione della base di dati.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Raccolta delle entità delle classi.
        /// </summary>
        public DbSet<Classe> Classi { get; set; }

        /// <summary>
        /// Raccolta delle entità dei moduli.
        /// </summary>
        public DbSet<Modulo> Moduli { get; set; }

        /// <summary>
        /// Raccolta delle entità delle tematiche.
        /// </summary>
        public DbSet<Tematica> Tematiche { get; set; }

        /// <summary>
        /// Raccolta delle entità degli anni.
        /// </summary>
        public DbSet<Anno> Anni { get; set; }

        /// <summary>
        /// Raccolta delle entità degli esercizi.
        /// </summary>
        public DbSet<Esercizio> Esercizi { get; set; }

        /// <summary>
        /// Raccolta delle entità degli esercizi delle prove.
        /// </summary>
        public DbSet<EsercizioProva> EserciziProva { get; set; }

        /// <summary>
        /// Raccolta delle entità delle prove.
        /// </summary>
        public DbSet<Prova> Prove { get; set; }

        /// <summary>
        /// Metodo costruttore vuoto (ereditato).
        /// </summary>
        public AppDbContext() : base()
        {
        }

        /// <summary>
        /// Metodo costruttore utilizzato per preparare il database.
        /// </summary>
        /// <param name="options">Configurazione del database.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Configurazione del percorso di memorizzazione del database SQLite.
        /// </summary>
        /// <param name="optionsBuilder">Opzioni del contesto di dati presenti nel sistema.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*optionsBuilder.UseSqlite("Data Source="
                    + System.AppDomain.CurrentDomain.BaseDirectory
                    + "GestioneEserciziDB.sqlite");*/
                optionsBuilder.UseSqlite("Data Source=D:\\Desktop\\Scuola\\4SAMT\\Progetti\\GestioneEsercizi"
                    + "\\Project\\GestioneEsercizi\\GestioneEsercizi.DA\\db\\GestioneEsercizi.sqlite");
            }
        }
    }
}