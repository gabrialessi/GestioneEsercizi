# Gestione Esercizi | Diario di lavoro - 07.11.2019

##### Gabriele Alessi

### Canobbio, 07.11.2019

## Lavori svolti

Oggi ho continuato con l'implementazione lavorando principalmente su EsercizioView e EsercizioViewModel. Prima però ho riguardato la View che riguarda le impostazioni di base in quanto ci sono problemi nel mostrare alcuni dati delle entità.

Concretamente sono riuscito a sviluppare la base della schermata per creare un nuovo esercizio.

```xml
<!-- Titolo esercizio -->
<TextBox x:Name="tbTitolo" Grid.Column="0" Grid.Row="0" Margin="5" />
<TextBlock IsHitTestVisible="False" Text="Titolo esercizio..." 
           VerticalAlignment="Center" Foreground="DarkGray" Margin="10 0 0 0">
    <TextBlock.Style>
        <Style TargetType="{x:Type TextBlock}">
            <Setter Property="Visibility" Value="Collapsed"/>
            <Style.Triggers>
                <DataTrigger Binding="{Binding Text, ElementName=tbTitolo}" Value="">
                    <Setter Property="Visibility" Value="Visible"/>
                </DataTrigger>
            </Style.Triggers>
        </Style>
    </TextBlock.Style>
</TextBlock>
<!-- Menu - Modulo, Tematica, Classe -->
<ComboBox Grid.Column="1" Grid.Row="0" SelectedIndex="0" 
          ItemsSource="{Binding Path=Moduli}" Margin="5" />
<ComboBox Grid.Column="2" Grid.Row="0" SelectedIndex="0" 
          ItemsSource="{Binding Path=Tematiche}" Margin="5" />
<ComboBox Grid.Column="3" Grid.Row="0" SelectedIndex="0" 
          ItemsSource="{Binding Path=Classi}" Margin="5" />
<!-- Immagine -->
<Grid Grid.Column="2" Grid.ColumnSpan="2" Grid.Row="1" 
      Margin="50" AllowDrop="True" Drop="Grid_Drop">
    <Label x:Name="lImmagine" Content="Immagine" />
    <Button x:Name="bSfoglia" VerticalAlignment="Center" 
        HorizontalAlignment="Center" Content="Sfoglia..." Click="bSfoglia_Click" />
</Grid>
```

<div style="page-break-after: always;"></div>

Ho trovato anche il modo di inserire le immagini sfogliando con l'explorer o tramite drag&drop.

```c#
private void bSfoglia_Click(object sender, RoutedEventArgs e)
{
    // Create OpenFileDialog 
    Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

    // Set filter for file extension and default file extension 
    dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

    // Display OpenFileDialog by calling ShowDialog method 
    Nullable<bool> result = dlg.ShowDialog();

    // Get the selected file name and display in a TextBox 
    if (result == true) lImmagine.Content = dlg.FileName;
}

private void Grid_Drop(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(DataFormats.FileDrop))
    {
        // Note that you can have more than one file.
        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        lImmagine.Content = files[0].ToString();
    }
}
```

Riferimenti:  
[Drag and drop WPF C# getting file path](https://www.codeproject.com/Questions/514592/DragplusandplusdropplusWPFplusC-23plusgettingplusf)  
[Open file dialog and select a file using WPF controls and C#](https://stackoverflow.com/questions/10315188/open-file-dialog-and-select-a-file-using-wpf-controls-and-c-sharp)

<div style="page-break-after: always;"></div>

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Alcuni dati delle entità nei `DataGrid` non vengono mostrati.

```c#
public ImpostazioniBaseViewModel()
{
    AppDbContext ctx = new AppDbContext();
    ClasseDbRepository repoClasse = new ClasseDbRepository(ctx);
    ModuloDbRepository repoModulo = new ModuloDbRepository(ctx);
    TematicaDbRepository repoTematica = new TematicaDbRepository(ctx);
    Classi = new ObservableCollection<Classe>(repoClasse.Get());
    Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
    Tematiche = new ObservableCollection<Tematica>(repoTematica.Get());
}
```

```xml
<DataGrid ItemsSource="{Binding Path=Classi}" />
<DataGrid ItemsSource="{Binding Path=Moduli}" />
<DataGrid ItemsSource="{Binding Path=Tematiche}" />
```

Riguardo a ciò ho chiesto aiuto al docente e pare che avrò una soluzione nei prossimi giorni.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
