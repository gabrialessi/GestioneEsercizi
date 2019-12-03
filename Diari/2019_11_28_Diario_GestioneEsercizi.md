# Gestione Esercizi | Diario di lavoro - 28.11.2019

##### Gabriele Alessi

### Canobbio, 28.11.2019

## Lavori svolti

Durante questa giornata ho lavorato all'implementazione del salvataggio di una prova. Per fare ciò ho dovuto eliminare da costruttore del modello di dati il parametro che rappresenta gli esercizi e poi ho potuto sviluppare il metodo di salvataggio nel ViewModel. Inoltre ho anche dovuto creare i servizi dell'`EsercizioProva` per poter inserire i dati dei nuovi esercizi nel database.

```c#
ProvaDbRepository repoProva = new ProvaDbRepository(new AppDbContext());
EsercizioProvaDbRepository repo = new EsercizioProvaDbRepository(new AppDbContext());
// Aggiungo la prova
Prova prova = new Prova(Titolo, Data, Anno);
repoProva.Insert(prova);
// Aggiungo gli esercizi della prova
foreach (Esercizio esercizio in new List<Esercizio>(Esercizi))
{
    repo.Insert(new EsercizioProva(esercizio, prova));
}
```

Per il resto del tempo ho documentato il lavoro svolto, cioè i ViewModels di Esercizio e Prova.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Ho un problema che riguarda il salvataggio della prova. Infatti ho bisogno di definire gli esercizi da inserire però non riesco a trovare un modo su come reperirli dalla View. Per ora utilizzo una `DataGridCheckBoxColumn` pensando di poter ottenere gli esercizi che vengono vistati, ma questo sistema sembra non funzionare. Dovrei consultare il docente per cercare una soluzione.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
