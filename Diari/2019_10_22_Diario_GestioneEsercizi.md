# Gestione Esercizi | Diario di lavoro - 22.10.2019

##### Gabriele Alessi

### Canobbio, 22.10.2019

## Lavori svolti

In questa giornata ho inizialmente riguardato l'intero progetto per poi consultare il docente responsabile e risolvere il problema riscontrato con la relazione tra Esercizio e EsercizioProva. Quindi siamo giunti alla conclusione che è necessario cambiare la relazione da uno a uno, a uno a molti.

```c#
/// <summary>
/// Modello di dati dell'esercizio.
/// </summary>
public class Esercizio : BaseEntity
{
    /// <summary>
    /// Titolo dell'esercizio.
    /// </summary>
    public string Titolo { get; set; }
    /// <summary>
    /// Testo dell'esercizio (include l'immagine).
    /// </summary>
    public string Testo { get; set; }
    /// <summary>
    /// Modulo relativo all'esercizio.
    /// </summary>
    public Modulo Modulo { get; set; }
    /// <summary>
    /// Esercizi della prova relativi all'esercizio.
    /// </summary>
    public ICollection<EsercizioProva> EserciziProva { get; set; }
}
```

Dunque ho continuato creando le Migrations e il Database tramite la console di gestione dei pacchetti NuGet.

>Add-Migration Initial  
>Update-Database -Verbose

<div style="page-break-after: always;"></div>

Poi ho anche trasferito il sistema del MainWindow nella MainView, anche se credevo ciò non fosse possibile a causa dei ViewModels gestiti in diverse Views.

Alla fine il docente mi ha spiegato un metodo per gestire la comunicazione tra più ViewModels (`Messenger`).

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In anticipo rispetto alla pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
