# Gestione Esercizi | Diario di lavoro - 26.11.2019

##### Gabriele Alessi

### Canobbio, 26.11.2019

## Lavori svolti

In questa giornata ho continuato con lo sviluppo delle Views lavorando soprattutto sulla parte della creazione di un esercizio. Prima però ho voluto eliminare il database per poi ricrearlo in modo da avere una versione definitiva in quanto i `Models` e l'`AppDbContext` dovrebbero essere conclusi dopo le ultime modifiche apportate. Ho impostato il percorso del database in modo che venga salvato nella cartella `AppData`, così facendo il sistema sarà uguale per qualunque utente.

```c#
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        string dbPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            + "\\GestioneEsercizi";
        Directory.CreateDirectory(dbPath);
        optionsBuilder.UseLazyLoadingProxies().UseSqlite(
            "Data Source=" + dbPath + "\\GestioneEsercizi.sqlite");
    }
}
```

Dopodiché ho deciso di eliminare il campo `Tematiche` dall'`EsercizioViewModel` perché mi sono reso conto che non è utile per la creazione di un nuovo esercizio in quanto nel database non viene considerato.

```xml
<ComboBox Grid.Column="1" Grid.Row="0" SelectedIndex="0"
          ItemsSource="{Binding Path=Moduli}" SelectedItem="{Binding Path=Modulo}"/>
```

```c#
public EsercizioViewModel()
{
    BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
    SalvaCommand = new DelegateCommand(OnSalva, CanSalva);
    ModuloDbRepository repoModulo = new ModuloDbRepository(new AppDbContext());
    Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
}
```

<div style="page-break-after: always;"></div>

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Mi manca poco per concludere la creazione dell'esercizio, però c'è un problema quando bisogna salvarlo nel database. Infatti non viene salvato il modulo relativo all'esercizio quando si esegue l'`Insert` tramite l'`EsercizioDbRepository`. Ho provato a cambiare la proprietà che salva il modulo dalla View da `Text={Binding Path=Modulo}` a `SelectedItem={Binding Path=Modulo}`, ma in questo modo viene dato un errore nel repository.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
