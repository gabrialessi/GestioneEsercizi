# Gestione Esercizi | Diario di lavoro - 15.11.2019

##### Gabriele Alessi

### Canobbio, 15.11.2019

## Lavori svolti

In questa giornata ho lavorato principalmente allo sviluppo delle Views del progetto su Visual Studio. Ho riguardato un po' in generale il sistema pensando a come continuare nei prossimi giorni. Ho pensato che la cosa più complicata sarà l'inserimento di una nuova impostazione di base, visto che è necessario farlo attraverso un sistema che permette di inserire anche i dati relativi all'entità interessata (ad esempio se inserisco una classe devo specificare un'annata che sia presente nel database). 

```xml
<!-- Tabelle con i dati -->
<DataGrid x:Name="classiDataGrid" Grid.Column="0" Grid.Row="1" 
          ItemsSource="{Binding Path=Classi}" />
<DataGrid x:Name="moduliDataGrid" Grid.Column="1" Grid.Row="1" 
          ItemsSource="{Binding Path=Moduli}" />
<DataGrid x:Name="tematicheDataGrid" Grid.Column="2" Grid.Row="1"
          ItemsSource="{Binding Path=Tematiche}" />
<!-- Pulsanti per aggiunta dati -->
<Button Grid.Column="0" Grid.Row="2" Content="Nuova classe"/>
<Button Grid.Column="1" Grid.Row="2" Content="Nuovo modulo" />
<Button Grid.Column="2" Grid.Row="2" Content="Nuova tematica" />
```

Nel frattempo ho documentato tutto ciò che ho concluso, quindi la MainView, BenvenutoView, AboutView, EsercizioListView e ProvaListView.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

<div style="page-break-after: always;"></div>

## Problemi riscontrati e soluzioni adottate

Continuo ad avere problemi nell'inserire i link alle pagine web nella AboutView. Ho già spiegato questo problema (viene sollevata un'eccezione) e vorrei rispolvere nei prossimi giorni chiedendo aiuto al docente ([Using Hyperlink in WPF](https://stackoverflow.com/questions/10238694/example-using-hyperlink-in-wpf)).

Poi ho anche problemi nel nascondere una colonna di una `GridView` visto che durante il debugging l'array `Columns` risulta vuoto.

```c#
eserciziDataGrid.Columns[0].Visibility = Visibility.Collapsed;
```

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
