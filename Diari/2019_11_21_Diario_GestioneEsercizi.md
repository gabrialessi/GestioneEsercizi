# Gestione Esercizi | Diario di lavoro - 21.11.2019

##### Gabriele Alessi

### Canobbio, 21.11.2019

## Lavori svolti

Durante questa giornata ho continuato lavorando sulle Views e sui ViewModels del progetto su Visual Studio. Inizialmente ho risolto il problema delle colonne del `DataGrid` mostrando solo quelle selezionate.

```xml
<!-- Classi -->
<DataGrid x:Name="classiDataGrid" Grid.Column="0" Grid.Row="1" IsReadOnly="True"
          ItemsSource="{Binding Path=Classi}" AutoGenerateColumns="False">
    <DataGrid.Columns>
        <DataGridTextColumn Header="Classe" Binding="{Binding Path=Nome}" />
        <DataGridTextColumn Header="Anno" Binding="{Binding Path=Anno}" />
    </DataGrid.Columns>
</DataGrid>
```

Poi ho continuato implementando il salvataggio durante la creazione di un esercizio. Per fare ciò ho prima dovuto modficare un paio di Models per far funzionare il sistema e poter creare una nuova entità `Esercizio`.

```c#
public Esercizio(string titolo, string testo, Modulo modulo)
{
    Titolo = titolo;
    Testo = testo;
    Modulo = modulo;
}

public Esercizio() { }
```

<div style="page-break-after: always;"></div>

Quindi ho sviluppato l'EsercizioViewModel e l'EsercizioView per implementare il salvataggio delle informazioni inserite e fare l'Insert del nuovo esercizio.

```c#
public string Titolo { get; set; }
public string Testo { get; set; }
public Modulo Modulo { get; set; }

public EsercizioViewModel()
{
    SalvaCommand = new DelegateCommand(OnSalva, CanSalva);
}

private void OnSalva(object obj)
{
    EsercizioDbRepository repoEsercizio = new EsercizioDbRepository(new AppDbContext());
    // Aggiungo l'esercizio
    repoEsercizio.Insert(new Esercizio(Titolo, Testo, Modulo));
    OnBenvenuto(obj);
}

private bool CanSalva(object arg) => true;
```

Non ho avuto molto tempo di testare questo codice e ho rilevato un problema nel metodo `Insert` della classe `DbDataRepository` in quanto non viene trovato il dato da mettere sotto la colonna `Discriminator` (dovrei chiedere al docente perché si crea questa colonna).

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
