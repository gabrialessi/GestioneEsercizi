# Gestione Esercizi | Diario di lavoro - 29.11.2019

##### Gabriele Alessi

### Canobbio, 29.11.2019

## Lavori svolti

Oggi ho continuato lavorando principalmente sulla documentazione del progetto. Sto cercando di concludere tutto ciò che non riguarda lo sviluppo dell'applicazione così da concentrarmi di più sulle ultime cose da implementare. Quindi ho rigurdato un po' la documentazione inserendo alcune immagini e scrivendo la `ProvaView`. Infine ho fatto la `GuidaView` e la `GuidaVieModel`, le quali non contengono parti di codice particolari ma solo parti di testo al fine di informare l'utente sull'utilizzo del prodotto.

```xml
<!-- Titolo -->
<Label FontSize="25" FontWeight="Bold" Content="Guida - Gestione Esercizi"/>
<!-- Introduzione -->
<Label FontSize="20" Content="Introduzione"/>
<TextBlock x:Name="introduzione" Style="{StaticResource styleTextBlock}"/>
<!-- Impostazioni base -->
<Label FontSize="20" Content="Impostazioni di Base"/>
<TextBlock x:Name="impostazioniBase" Style="{StaticResource styleTextBlock}"/>
<!-- Nuovo Esercizio -->
<Label FontSize="20" Content="Nuovo Esercizio"/>
<TextBlock x:Name="esercizio" Style="{StaticResource styleTextBlock}"/>
<!-- Creazione Prova -->
<Label FontSize="20" Content="Creazione Prova"/>
<TextBlock x:Name="prova" Style="{StaticResource styleTextBlock}"/>
```

Poi ho anche creato i ViewModels utili per la creazione di nuove impostazioni di base. Ho dovuto fare ciò perché quando si vuole inserire una nuova entità sarebbe necessario usare il sistema dei Models e dei Repository quindi bisogna creare anche una View per ogni elemento che si vuole aggiungere.

```c#
private void OnSalva(object obj)
{
    ClasseDbRepository repo = new ClasseDbRepository(new AppDbContext());
    // Aggiungo la classe
    repo.Insert(new Classe(Nome, Anno));
    OnBenvenuto(obj);
}
```

<div style="page-break-after: always;"></div>

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
