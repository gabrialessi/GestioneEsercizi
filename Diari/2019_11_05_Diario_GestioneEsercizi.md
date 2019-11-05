# Gestione Esercizi | Diario di lavoro - 05.11.2019

##### Gabriele Alessi

### Canobbio, 05.11.2019

## Lavori svolti

Durante questa giornata ho continuato con lo sviluppo delle Views e dei ViewModels del progetto. Prima di cominciare ho riguardato il punto della situazione e quindi ho chiesto aiuto al docente riguardo agli errori riscontrati prima delle vacanze sul database e sui pacchetti NuGet. Ho risolto ricostruendo il database e la Migration dopo aver reimpostato il percorso assoluto nel `AppDbContext`.

Oltre a ciò ho ripreso con lo sviluppo della View e del ViewModel delle impostazioni di base. Dopo aver corretto il database ho implementato i metodi `ToString()` utili per stampare le informazioni nei `DataGrid` correttamente.

```c#
public class Tematica : BaseEntity
{
    public string Nome { get; set; }
    public Modulo Modulo { get; set; }
    public override string ToString()
    {
        return Nome;
    }
}
```

Quindi ora che ho il controllo del database e dei ViewModels dovrei riuscire a concludere il capitolo delle impostazioni di base per questa settimana.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
