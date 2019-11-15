# Gestione Esercizi | Diario di lavoro - 14.11.2019

##### Gabriele Alessi

### Canobbio, 14.11.2019

## Lavori svolti

Oggi ho maggiormente lavorato sulla documentazione delle Views e dei ViewModels del progetto. La prima cosa che ho fatto però è l'implementazione del drag&drop nella schermata di creazione di un esercizio. Riassumendo ho sempificato un po' il codice provissorio di qualche giorno fa correggendo il filtro dei files e migliorando la notifica del file inserito.

```xml
<!-- Immagine -->
<Border Grid.Column="2" Grid.ColumnSpan="2" Grid.Row="1"
        BorderBrush="Black" BorderThickness=".5" Margin="50"
        AllowDrop="True" Drop="Image_Drop">
    <Grid>
        <Label x:Name="lImmagine" Content="Trascina immagine" />
        <Button x:Name="bSfoglia" VerticalAlignment="Center"
        HorizontalAlignment="Center" Content="Sfoglia..." Click="bSfoglia_Click" />
    </Grid>
</Border>
```

```c#
private void bSfoglia_Click(object sender, RoutedEventArgs e)
{
    // Creazione File Explorer
    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
    // Impostazione estensioni files
    dlg.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif";
    // Mostrare il file selezionato nella label
    if (dlg.ShowDialog() == true) SetLabelContent(dlg.FileName);
}
private void Image_Drop(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(DataFormats.FileDrop))
    {
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        SetLabelContent(files[0]);
    }
}
private void SetLabelContent(string filename)
{
    lImmagine.Content = Path.GetFileName(filename);
}
```

<div style="page-break-after: always;"></div>

Successivamente ho velocemente creato una bozza del ViewModel e della View per la guida del prodotto, che dovrebbe essere l'ultimo elemento del sistema:

- BenvenutoViewModel
- AboutViewModel
- GuidaViewModel
- EsercizioListViewModel
- ProvaListViewModel
- ImpostazioniBaseViewModel
- EsercizioViewModel
- ProvaViewModel

Per la documentazione ho concluso i capitoli sulla MainView e la BenvenutoView.

>La MainView è l’interfaccia principale e ha il compito di rappresentare il MainViewModel, quindi viene selezionata la View da mostrare attraverso i Commands e il campo CurrentViewModel.
Sono inoltre presenti i riferimenti di tutti gli altri ViewModels e le rispettive Views nella sezione delle risorse.
Questa View sarà l’unico contenuto presente nella finestra principale del progetto, cioè MainWindow.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Ho problemi nell'implementare dei link a delle pagine web nella schermata di informazioni, ho cercato diversi modi di fare ciò ma non trovo soluzioni.

```xml
<Label Grid.Column="1" Grid.Row="1"
    VerticalAlignment="Center" HorizontalAlignment="Center">
<Hyperlink
    NavigateUri="https://github.com/gabrialessi/GestioneEsercizi">
    GestioneEsercizi
</Hyperlink>
```

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
