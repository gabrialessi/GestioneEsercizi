# Gestione Esercizi | Diario di lavoro - 17.10.2019

##### Gabriele Alessi

### Canobbio, 17.10.2019

## Lavori svolti

Durante questa giornata ho continuato con lo sviluppo delle interfacce grafiche del progetto su Visual Studio. Ho implementato diverse modifiche rispetto a ciò che avevo in mente fino alla scorsa settimana. Infatti dal sistema che ho sviluppato risulta necessario implementare la gestione dei ViewModels e delle Views nella MainWindow, e non nella MainView.

```c#
<Window.DataContext>
    <viewmodel:MainViewModel/>
</Window.DataContext>
<Window.Resources>
    <DataTemplate DataType="{x:Type viewmodel:AboutViewModel}">
        <view:AboutView/>
    </DataTemplate>
    <DataTemplate DataType="{x:Type viewmodel:BenvenutoViewModel}">
        <view:BenvenutoView/>
    </DataTemplate>
</Window.Resources>
<Grid>
    <DockPanel>
        <Menu DockPanel.Dock="Top">
            <MenuItem Header="_File">
                <MenuItem Header="_Esercizi"/>
                <MenuItem Header="_Prove"/>
                <MenuItem Header="_Opzioni"/>
                <MenuItem x:Name="miEsci" Header="_Esci" Click="miEsci_Click"/>
            </MenuItem>
            <MenuItem Header="_Info">
                <MenuItem Header="_Guida"/>
                <MenuItem Header="_About" Command="{Binding Path=AboutCommand}"/>
            </MenuItem>
        </Menu>
        <StackPanel></StackPanel>
    </DockPanel>
    <ContentControl Content="{Binding Path=CurrentViewModel}"/>
</Grid>
```

Il fatto è che utilizzo il menu (`<DockPanel>`) in cui dovrei chiamare diverse Views, quindi la soluzione è stata quella di includere tutto nel MainWindow.

<div style="page-break-after: always;"></div>

Di conseguenza ho dovuto cancellare la AboutWindow e ho creato una AboutView, AboutViewModel e BenvenutoViewModel.

```c#
public class AboutViewModel : BindableBase
{
    public AboutViewModel()
    {
    }
}

public class BenvenutoViewModel : BindableBase
{
    public BenvenutoViewModel()
    {
    }
}
```

Neanche oggi il docente si è presentato e ho bisogno abbastanza urgente di verificare quanto fatto finora e fare alcune domande sul sistema da adottare per quanto riguarda gli altri ViewModels e la gestione delle Views e dei dati.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

Abbastanza in anticipo rispetto alla pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
