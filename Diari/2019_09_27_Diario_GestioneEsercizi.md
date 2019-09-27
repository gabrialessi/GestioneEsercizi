# Gestione Esercizi | Diario di lavoro - 27.09.2019
##### Gabriele Alessi
### Canobbio, 27.09.2019

## Lavori svolti

Durante questa giornata ho lavorato all'implementazione della base del progetto su Visual Studio. Fondamentalmente ho già deciso di cambiare da quanto progettato perché dopo aver visto i progetti dell'anno scorso ho optato per la creazione di una libreria di classi (GestioneEsercizi.DA) in cui inserire tutte le classi di base del database.  
Un altro grosso cambiamento è il fatto di usare .NET Core, in quanto dopo aver visto l'articolo ["Differenze .NET Core vs .NET Framework"](https://www.c-sharpcorner.com/article/difference-between-net-framework-and-net-core/) e i vecchi progetti scolastici ho pensato che sarebbe più semplice.

><img src="../Documentazione/Immagini/StrutturaBase.png" alt="UseCase" width=400>
>
> Per iniziare si crea una Soluzione Vuota che fungerà da contenitore generale, quindi si inseriscono i progetti del sistema .NET Core, cioè una App WPF e una Libreria di Classi. Il prossimo passo è l’implementazione dei pacchetti necessari per la gestione dei dati tramite il gestore NuGet. 

Questa è la nuova struttura di base, dove ci sono le classi di base e dove sono presenti tutti i pacchetti necessari per la gestione dei dati.

<div style="page-break-after: always;"></div>

Inoltre ho iniziato a sviluppare le classi riguardanti il database (DataRepository e DbContext) usando come punto di riferimento i progetti dell'anno scorso del modulo 223.

<img src="../Documentazione/Immagini/IDataRepository.png" alt="UseCase" width=500>

<img src="../Documentazione/Immagini/AppDbContext.png" alt="UseCase" width=500>

Infine ho rifinito la documentazione inserendo le nuove informazioni nel capitolo di implementazione e definendo i nuovi sottocapitoli.

Per un'ora non ho potuto lavorare perché sono stato impegnato con una riunione riguardo lo stage all'estero.

| Orario | Lavori svolti |
| - | - |
|13:15 - 14:45 / 15:45 - 16:30 | Implementazione e Documentazione |

##  Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

##  Punto della situazione rispetto alla pianificazione

In anticipo di circa una settimana con la pianificazione. 

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.