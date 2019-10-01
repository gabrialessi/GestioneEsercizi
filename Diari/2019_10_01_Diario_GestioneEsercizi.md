# Gestione Esercizi | Diario di lavoro - 01.10.2019
##### Gabriele Alessi
### Canobbio, 01.10.2019

## Lavori svolti

Durante questa giornata mi sono principalmente concentrato sullo sviluppo del programma.  
Inizialmente mi sono consultato con il docente per fare il punto della situazione e guardare un po' il lavoro fatto finora (il fatto di usare .NET Core e la struttura usata l'anno scorso). A quanto pare è tutto a posto e lo sviluppo procede in maniera soddisfacente, quindi ho continuato implementando gli ultimi modelli di dati (Anno, Prova, Esercizio e EsercizioProva). Ho lavorato anche sulla documentazione, aggiornando il capitolo di creazione progetto e concludendo il capitolo dei Models.

><img src="../Documentazione/Immagini/StrutturaBase.png" alt="UseCase" width=300>
>
>Dall’immagine si può vedere che i pacchetti utilizzati sono quelli inerenti a EntityFrameworkCore, infatti questi sono utili per l’accesso ai dati e la gestione del database (in questo caso SQLite).

>La Libreria di Classi (.NET Core) è uno dei progetti della soluzione Visual Studio e contiene tutto ciò che ha a che fare con la gestione dei dati e la definizione del database.  
La cartella Models contiene le entità di base del sistema che rappresentano i dati, quindi per fare ciò si fa riferimento al diagramma del database.  
BaseEntity è la superclasse principale ed è la base di ogni altra entità, infatti essa contiene solo l’Id, che è un campo comune a ogni oggetto.

```c#
public class BaseEntity
{
    public int Id { get; set; }
}
```

<div style="page-break-after: always;"></div>

>La classe Modulo presenta i campi che descrivono il nome (Modulo x), l’anno, le tematiche e gli esercizi.

```c#
public class Modulo : BaseEntity
{
    public string Nome { get; set; }
    public Anno Anno { get; set; }
    public ICollection<Tematica> Tematiche { get; set; }
    public ICollection<Esercizio> Esercizi { get; set; }
}
```

La classe Anno è principalmente utilizzata per collegare una classe e un modulo con una prova. Fondamentalmente la classe include l’annata e gli insiemi di classi, moduli e prove.

```c#
public class Anno : BaseEntity
{
    public string Annata { get; set; }
    public ICollection<Classe> Classi { get; set; }
    public ICollection<Modulo> Moduli { get; set; }
    public ICollection<Prova> Prove { get; set; }
}
```

Per la prossima giornata cercherò di completare anche il capitolo riguardo i Services, quindi le interfacce che interagiscono con il database.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

##  Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

##  Punto della situazione rispetto alla pianificazione

Abbastanza in anticipo rispetto alla pianificazione. 

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.