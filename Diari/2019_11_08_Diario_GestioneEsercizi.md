# Gestione Esercizi | Diario di lavoro - 08.11.2019

##### Gabriele Alessi

### Canobbio, 08.11.2019

## Lavori svolti

Ho dedicato questa giornata interamente alla documentazione. In generale ho rivisto velocemente i primi capitoli per avere il punto della situazione e poi ho pulito il codice della libreria di classi semplificando anche la documentazione.

```c#
public abstract class DbDataRepository<C, T> : IDataRepository<T> where T : BaseEntity
                                                                  where C : DbContext, new()
{
    protected C context;
    protected DbDataRepository(C ctx) => context = ctx;

    public T Get(int id) => Get().SingleOrDefault(be => be.Id == id);

    public virtual IQueryable<T> Get() => context.Set<T>();

    public virtual T Insert(T entity)
    {
        context.Set<T>().Add(entity);
        context.SaveChanges();
        return entity;
    }

    public virtual void Update(T entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        context.SaveChanges();
    }

    public virtual void Delete(T entity)
    {
        context.Set<T>().Remove(entity);
        context.SaveChanges();
    }
}
```

<div style="page-break-after: always;"></div>

```c#
public class AppDbContext : DbContext
{
    public DbSet<Classe> Classi { get; set; }
    public DbSet<Modulo> Moduli { get; set; }
    public DbSet<Tematica> Tematiche { get; set; }
    public DbSet<Anno> Anni { get; set; }
    public DbSet<Esercizio> Esercizi { get; set; }
    public DbSet<EsercizioProva> EserciziProva { get; set; }
    public DbSet<Prova> Prove { get; set; }

    public AppDbContext() : base() { }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string dbPath =
                "D:\\Desktop\\Scuola\\4SAMT\\Progetti\\GestioneEsercizi\\Project"
                + "\\GestioneEsercizi\\GestioneEsercizi.DA\\db\\GestioneEsercizi.sqlite";
            optionsBuilder.UseSqlite("Data Source=" + dbPath);
        }
    }
}
```

>Successivamente è necessario creare il database tramite la console di gestione dei pacchetti. La prima cosa da fare è la creazione delle migrazioni, le quali definiscono i parametri del database tramite il DbContext, per poi aggiornare la base di dati.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
