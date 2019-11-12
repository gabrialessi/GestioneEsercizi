# Gestione Esercizi | Diario di lavoro - 12.11.2019

##### Gabriele Alessi

### Canobbio, 12.11.2019

## Lavori svolti

Durante questa giornata ho continuato a lavorare principalmente sui ViewModels del progetto su Visual Studio. Inizialmente ho provato la soluzione trovata dal docente responsabile riguardo agli output nelle Views dei dati provenienti dai Models. Per fare ciò ho installato il pacchetto `Microsoft.EntityFrameworkCore.Proxies` e ho implementato il metodo nell'`AppDbContext` modificando i campi interessati tramite la keyword `virtual` ([Lazy Loading](https://stackoverflow.com/questions/50180326/how-to-make-lazy-loading-work-with-ef-core-2-1-0-and-proxies/52432651)).

```c#
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        string dbPath =
            "D:\\Desktop\\Scuola\\4SAMT\\Progetti\\GestioneEsercizi\\Project"
            + "\\GestioneEsercizi\\GestioneEsercizi.DA\\db\\GestioneEsercizi.sqlite";
        optionsBuilder.UseLazyLoadingProxies().UseSqlite("Data Source=" + dbPath);
    }
}
```

```c#
public class Classe : BaseEntity
{
    public string Nome { get; set; }
    public virtual Anno Anno { get; set; }
    public override string ToString() => Nome;
}
```

Per il resto oltre al problema riscontrato ho proseguito pulendo il codice semplificandolo e ho fatto un po' di documentazione concludendo il capitolo del `MainViewModel`.

<div style="page-break-after: always;"></div>

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nonostante la soluzione del Lazy Loading trovata alcuni dati non vengono mostrati. Questo vale per i Models che presentano campi `ICollection` come il `Modulo`.

```c#
public class Modulo : BaseEntity
{
    public string Nome { get; set; }
    public virtual Anno Anno { get; set; }
    public virtual ICollection<Tematica> Tematiche { get; set; }
    public virtual ICollection<Esercizio> Esercizi { get; set; }
    public override string ToString() => Nome;
}
```

Ne ho parlato con il docente e ha detto che cercherà una soluzione per questo.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
