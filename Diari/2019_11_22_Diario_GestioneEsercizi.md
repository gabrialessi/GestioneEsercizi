# Gestione Esercizi | Diario di lavoro - 22.11.2019

##### Gabriele Alessi

### Canobbio, 22.11.2019

## Lavori svolti

Oggi durante le prime due ore ho prima di tutto implementato i metodi costruttori in tutti i Models del progetto su Visual Studio. Questo perché ci sono problemi con i DBrepository che hanno bisogno di lavorare con i modelli e i metodi degli stessi repository per funzionare correttamente. In contemporanea a ciò ho anche aggiornato la documentazione sperando di non modificare più questi capitoli base.

```c#
public Prova(string titolo, DateTime data, Anno anno, ICollection<EsercizioProva> esercizi)
{
    Titolo = titolo;
    Data = data;
    Anno = anno;
    EserciziProva = esercizi;
}
```

Poi ho cominciato a sviluppare la View e il ViewModel della creazione della prova. Prima ho dovuto creare il repository per il modello dell'anno.

```c#
public AnnoDbRepository(AppDbContext ctx) : base(ctx) { }
```

Successivamente ho implementato il ViewModel (simile a quello per l'esercizio) e la View.

```xml
<!-- Data della prova -->
<DatePicker x:Name="dataDatePicker" SelectedDate="{Binding Path=Data}" />
<!-- Anno della prova -->
<ComboBox  ItemsSource="{Binding Path=Anni}" Text="{Binding Path=Anno}" />
<!-- Griglia con i dati degli esercizi -->
<DataGrid x:Name="eserciziDataGrid" ItemsSource="{Binding Path=Esercizi}" AutoGenerateColumns="False">
    <DataGrid.Columns>
        <DataGridTextColumn Header="Titolo" Binding="{Binding Path=Titolo}" />
        <DataGridTextColumn Header="Modulo" Binding="{Binding Path=Modulo}" />
        <DataGridCheckBoxColumn Header="Inserire nella prova" 
                                Selector.IsSelected="{Binding Path=Esercizio}" />
    </DataGrid.Columns>
</DataGrid>
```

<div style="page-break-after: always;"></div>

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Mentre stavo creando il necessario per far funzionare il ViewModel della prova mi sono accorto che ci sono dei problemi di base che riguardano la struttura del database. Infatti non mi è chiaro come funziona l'entità `EsercizioProva` e come devo utilizzarla nel discorso della creazione della prova. L'altra entità che collega il tutto è `Anno`, quindi devo chiarire con il docente come utilizzare questi oggetti per avere un sistema coerente.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
