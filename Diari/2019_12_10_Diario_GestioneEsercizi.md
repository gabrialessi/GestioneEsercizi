# Gestione Esercizi | Diario di lavoro - 10.12.2019

##### Gabriele Alessi

### Canobbio, 10.12.2019

## Lavori svolti

Durante questa giornata ho continuato con l'implementazione delle Views proseguendo anche con la rispettiva documentazione. Posso dire di aver concluso tutto tranne le parti dell'esercizio e della prova. Inizialmente ho documentato le impostazioni di base e le Views relative alla loro aggiunta (`ClasseView`, `ModuloView`, `TematicaView`).

>Questa View serve ad aggiungere una nuova classe nel sistema definendo il nome della classe e l’anno.

```c#
<TextBox Text="{Binding Path=Nome}"/>
<ComboBox ItemsSource="{Binding Path=Anni}" SelectedItem="{Binding Path=Anno}" />
```

Poi mi sono concentrato cercando di concludere l'`EsercizioView` implementando l'inserimento dell'immagine nel testo dell'esercizio. Prima di tutto ho cambiato la struttura della View sviluppando un contenitore fatto apposta per vedere l'anteprima dell'immagine, uno spazio per fare il drag&drop e infine il pulsante per sfogliare tra i file.

```xml
<Image x:Name="immagine" Source="{Binding Path=Immagine}" />
<Button Content="Sfoglia..." Click="Sfoglia" />
<Label Content="Trascina l'immagine qui" AllowDrop="True" Drop="ImageDrop"/>
```

Quindi nel ViewModel ho dovuto aggiungere la proprietà per ottenere tramite il Binding l'immagine inserita:  
`public BitmapImage Immagine { get; set; }`

Infine nella parte di codice della View ho sviluppato un metodo in modo che la sorgente dell'immagine fosse implementata correttamente.

```c#
private void SetImage(string filename)
    => immagine.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));
```

<div style="page-break-after: always;"></div>

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Ho riscontrato dei problemi per quanto riguarda l'ottenimento dell'immagine nel ViewModel tramite il Binding. Infatti la proprietà rimane a null nonostante vari tentativi di debug. La proprietà è di tipo `BitmapImage` in quanto la Source dell'immagine ha bisogno di questo tipo ma comunque non funziona.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
