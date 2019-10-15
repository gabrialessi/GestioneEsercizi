# Gestione Esercizi | Diario di lavoro - 15.10.2019

##### Gabriele Alessi

### Canobbio, 15.10.2019

## Lavori svolti

Oggi ho cominciato a sviluppare le Views del progetto su Visual Studio. Ho deciso di lasciare un attimo in sospeso i ViewModels perché lavorando sulle Views capirei meglio le implementazioni da completare. Come prima cosa ho creato la MainView e BenvenutoView, cioè la schermata principale che contiene i tre pulsanti per le opzioni principali.

```xml
<Button
    VerticalAlignment="Center"
    HorizontalAlignment="Center"
    Content="Impostazioni di Base"
    Padding="10" >
</Button>
<Button
    Grid.Column="1"
    VerticalAlignment="Center"
    HorizontalAlignment="Center"
    Content="Nuovo Esercizio"
    Padding="10" >
</Button>
<Button
    Grid.Column="2"
    VerticalAlignment="Center"
    HorizontalAlignment="Center"
    Content="Creazione Prova"
    Padding="10" >
</Button>
```

Inoltre ho inziato a implementare il menu che si trova nella MainWindow.

```xml
<DockPanel>
    <Menu DockPanel.Dock="Top">
        <MenuItem Header="_File">
            <MenuItem Header="_Esercizi"/>
            <MenuItem Header="_Prove"/>
            <MenuItem Header="_Opzioni"/>
            <MenuItem x:Name="miEsci" Header="_Esci" Click="miEsci_Click"/>
        </MenuItem>
    </Menu>
</DockPanel>
```

<div style="page-break-after: always;"></div>

Infine ho inziato i implementare la finestra `About` che si trova sotto il menu `Info` e presenta informazioni come l'autore, il riferimento a GitHub e la versione.

```xml
<TextBlock
    Grid.Column="1" 
    Grid.Row="1" 
    HorizontalAlignment="Center"
    VerticalAlignment="Center">
    Gestione Esercizi
    <LineBreak/>
    <Hyperlink 
        NavigateUri="https://github.com/gabrialessi/GestioneEsercizi">
        GitHub
    </Hyperlink>
</TextBlock>
<Button 
    Grid.Column="2"
    Grid.Row="2"
    x:Name="bChiudi"
    HorizontalAlignment="Right"
    VerticalAlignment="Bottom"
    Margin="15"
    Width="80"
    Content="Chiudi" Click="bChiudi_Click">
</Button>
```

Dovrei consultare il docente che oggi non sono riuscito a incontrare per riguardare un po' la struttura generale in quanto nel mio progetto sono presenti diversi elementi e devo capire meglio come metterli insieme.

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

Abbastanza in anticipo rispetto alla pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
