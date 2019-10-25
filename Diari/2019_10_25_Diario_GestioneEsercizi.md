# Gestione Esercizi | Diario di lavoro - 25.10.2019

##### Gabriele Alessi

### Canobbio, 25.10.2019

## Lavori svolti

Oggi ho proseguito con lo sviluppo delle Views e dei ViewModels del progetto su Visual Studio. Nel dettaglio mi sono dedicato all'implementazione dei ViewModels tenendo conto del database, quindi ho modificato alcuni parametri della connessione e ho inserito alcuni dati. A proposito di questo ho riscontrato dei problemi (descritti sotto), però poi ho continuato sviluppando la View e il ViewModel della lista di prove memorizzate.

```c#
public class ProvaListViewModel : BindableBase
{
    private BenvenutoViewModel benvenutoViewModel;
    public IDelegateCommand BenvenutoCommand { get; set; }
    public ObservableCollection<Prova> Prove { get; set; }

    public ProvaListViewModel()
    {
        RegisterCommands();
        ProvaDbRepository repo = new ProvaDbRepository(new AppDbContext());
        Prove = new ObservableCollection<Prova>(repo.Get());
    }
    [...]
```

```xml
<UserControl.DataContext>
    <viewmodel:ProvaListViewModel/>
</UserControl.DataContext>
<Grid Margin="10">
    <Grid.RowDefinitions>
        <RowDefinition Height="*"/>
        <RowDefinition Height="auto"/>
    </Grid.RowDefinitions>
    <DataGrid Grid.Row="0" ItemsSource="{Binding Path=Prove}"/>
    <Button 
        Grid.Row="1" Content="Indietro" Margin="10" Width="100"
        VerticalAlignment="Bottom" HorizontalAlignment="Right"
        Command="{Binding Path=BenvenutoCommand}" />
</Grid>
```

<div style="page-break-after: always;"></div>

Infine ho provato a nascondere certe colonne nelle ListView mostrando solo quelle interessate (Titolo, Data, ...). Purtroppo anche a questo non ho trovato una soluzione funzionante per ora.

```c#
public EsercizioListView()
{
    InitializeComponent();
    this.dgEsercizi.Columns[1].Visibility = Visibility.Collapsed;
    this.dgEsercizi.Columns[3].Visibility = Visibility.Collapsed;
    this.dgEsercizi.Columns[4].Visibility = Visibility.Collapsed;
}

```

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Ho riscontrato problemi che riguardano i pacchetti NuGet. Infatti, dopo aver cambiato il percorso della connessione al database SQLite e aver inserito alcuni dati, non vengono identificate le tabelle.

```c#
optionsBuilder.UseSqlite("Data Source="
    + System.AppDomain.CurrentDomain.BaseDirectory
    + "GestioneEserciziDB.sqlite");
```

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
