# Gestione Esercizi | Diario di lavoro - 03.10.2019
##### Gabriele Alessi
### Canobbio, 03.10.2019

## Lavori svolti

Oggi ho lavorato principalmente alla revisione del codice sviluppato durante questi giorni e poi ho documentato il tutto. Inizialmente ho voluto rifare il codice implementando i commenti ([Documentation comments](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments)) e capire meglio il funzionamento del sistema **Services**.

Questo è un esempio di una classe di modello di dati documentata:

```c#
/// <summary>
/// Modello di dati del modulo.
/// </summary>
public class Modulo : BaseEntity
{
    /// <summary>
    /// Nome del modulo (esempio: "Modulo 151").
    /// </summary>
    public string Nome { get; set; }
    /// <summary>
    /// Anno del modulo.
    /// </summary>
    public Anno Anno { get; set; }
    /// <summary>
    /// Insieme delle tematiche del modulo.
    /// </summary>
    public ICollection<Tematica> Tematiche { get; set; }
    /// <summary>
    /// Insieme degli esercizi del modulo.
    /// </summary>
    public ICollection<Esercizio> Esercizi { get; set; }
}
```

<div style="page-break-after: always;"></div>

Poi ho proseguito sviluppando le classi relative all'interfacciamento con i dati e il database (Services) e per la prossima giornata dovrei concluderlo.

```c#
/// <summary>
/// Interfaccia di base che implementa i metodi relativi alle 
/// operazioni sui dati nel database.
/// </summary>
/// <typeparam name="T">Modello di dati di riferimento.</typeparam>
public interface IDataRepository<T> where T : BaseEntity
{
    
    T Get(int id);
    
    IQueryable<T> Get();
    
    T Insert(T entity);
    
    void Update(T entity);

    void Delete(T entity);
}
```

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

##  Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

##  Punto della situazione rispetto alla pianificazione

Abbastanza in anticipo rispetto alla pianificazione. 

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.