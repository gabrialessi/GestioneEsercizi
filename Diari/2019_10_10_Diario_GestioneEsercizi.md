# Gestione Esercizi | Diario di lavoro - 10.10.2019

##### Gabriele Alessi

### Canobbio, 10.10.2019

## Lavori svolti

Durante questa giornata mi sono principalmente occupato dell'implementazione delle classi ViewModel sul progetto WPF di Visual Studio. Prima di tutto ho rinominato le classi in quanto prima contenevano la parola "List" (`ClasseListViewModel`) perché erano progettate per mostrare solo la lista di dati, mentre invece possono avere altre funzioni.

```c#
public class ProvaViewModel : BindableBase
{
    /// <summary>
    /// Insieme dinamico dei dati delle prove.
    /// </summary>
    public ObservableCollection<Prova> Prove { get; set; }
    /// <summary>
    /// Metodo costruttore del ViewModel.
    /// </summary>
    public ProvaViewModel()
    {
        ProvaDbRepository repo = new ProvaDbRepository(new AppDbContext());
        Prove = new ObservableCollection<Prova>(repo.Get());
    }
}
```

Per ora ho quasi concluso il capitolo ViewModels, manca solo da capire come gestire il MainViewModel e infine completare le classi dopo aver progettato la struttura delle Views.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

Abbastanza in anticipo rispetto alla pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
