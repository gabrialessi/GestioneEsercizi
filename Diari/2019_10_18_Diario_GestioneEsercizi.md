# Gestione Esercizi | Diario di lavoro - 18.10.2019

##### Gabriele Alessi

### Canobbio, 18.10.2019

## Lavori svolti

Oggi ho continuato a lavorare alle interfacce grafiche del progetto Visual Studio. Inizialmente ho creato un pulsante nella schermata `About` per tornare indietro alla schermata di benvenuto (che per ora non funziona anche a causa dei problemi riscontrati).

```xml
<Button x:Name="bChiudi" Grid.Column="2" Grid.Row="2" 
        Content="Indietro" VerticalAlignment="Bottom" Margin="20"
        Command="{Binding Path=BenvenutoCommand}" />
```

Poi ho sviluppato la View delle impostazioni di base, che è quella che mi ha creato problemi dopo l'implementazione di `ImpostazioniDiBaseViewModel`.

```xml
<UserControl.DataContext>
    <viewmodel:ImpostazioniBaseViewModel/>
</UserControl.DataContext>
<Grid Margin="50">
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="*" />
        <ColumnDefinition Width="*" />
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="auto" />
    </Grid.RowDefinitions>
    <DataGrid Grid.Column="0" Grid.Row="0" ItemsSource="{Binding Path=Classi}"/>
    <DataGrid Grid.Column="1" Grid.Row="0" ItemsSource="{Binding Path=Moduli}"/>
    <DataGrid Grid.Column="2" Grid.Row="0" ItemsSource="{Binding Path=Tematiche}"/>
    <Button Grid.Column="0" Grid.Row="1" Content="+" FontSize="18" />
    <Button Grid.Column="1" Grid.Row="1" Content="+" FontSize="18" />
    <Button Grid.Column="2" Grid.Row="1" Content="+" FontSize="18" />
</Grid>
```

<div style="page-break-after: always;"></div>

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

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Ho riscontrato un problema che riguarda la relazione uno a uno tra `Esercizio` e `EsercizioProva`:
>The child/dependent side could not be determined for the one-to-one relationship between 'Esercizio.EsercizioProva' and 'EsercizioProva.Esercizio'. To identify the child/dependent side of the relationship, configure the foreign key property. If these navigations should not be part of the same relationship configure them without specifying the inverse.

La possibile soluzione si trova in [questo link](https://docs.microsoft.com/it-it/ef/core/modeling/relationships#one-to-one) ma comunque non sono riuscito a risolvere il problema.  

```c#
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Esercizio>()
        .HasOne(p => p.EsercizioProva)
        .WithOne(i => i.Esercizio)
        .HasForeignKey<EsercizioProva>(b => b.Esercizio);
}
```

Ho pensato di cambiare la struttura e creare una dipendenza ma dovrei riguardare con il docente questa relazione così da trovare una soluzione.

## Punto della situazione rispetto alla pianificazione

Abbastanza in anticipo rispetto alla pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
