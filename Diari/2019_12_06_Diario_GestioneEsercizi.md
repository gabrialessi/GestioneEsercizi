# Gestione Esercizi | Diario di lavoro - 06.12.2019

##### Gabriele Alessi

### Canobbio, 06.12.2019

## Lavori svolti

Oggi ho lavorato all'implementazione del progetto su Visual Studio e nel frattempo ho cercato di portarmi avanti con la documentazione. In generale sono a buon punto per quanto riguarda lo sviluppo dell'applicazione, manca solo qualche modulo qua e là per iniziare a concludere la cosa.  
Come prima cosa ho sviluppato l'algoritmo che aggiunge l'entità `Anno` in base alla data corrente quando si avvia l'applicazione.

```c#
AnnoDbRepository repo = new AnnoDbRepository(new AppDbContext());
// Anno corrente
string anno = DateTime.Today.Year.ToString()
        + "/" + (DateTime.Today.Year + 1).ToString();
// Inserisco l'anno se non è presente
try
{
    if (repo.Get().FirstOrDefault().Annata != anno) repo.Insert(new Anno(anno));
}
catch (NullReferenceException)
{
    repo.Insert(new Anno(anno));
}
```

Dopodiché ho concluso i Models e il database implementando le ultime proprietà per la gestione delle FK.

```c#
public class EsercizioProva : BaseEntity
{
    public virtual Esercizio Esercizio { get; set; }

    public int EsercizioId { get; set; }

    public virtual Prova Prova { get; set; }

    public int ProvaId { get; set; }

    public EsercizioProva(Esercizio esercizio, Prova prova)
    {
        EsercizioId = esercizio.Id;
        ProvaId = prova.Id;
    }
}
```

<div style="page-break-after: always;"></div>

Quindi ho continuato sistemando tutto ciò che riguarda Views e ViewModels delle impostazioni di base concludendo questo capitolo (anche nella documentazione).

![Impostazioni Base View](../Documentazione/Immagini/Base.png)

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
