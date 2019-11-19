# Gestione Esercizi | Diario di lavoro - 19.11.2019

##### Gabriele Alessi

### Canobbio, 19.11.2019

## Lavori svolti

Oggi ho continuato con l'implementazione delle Views completando anche la documentazione di alcuni ViewModels.

> Gli elementi presenti in questa View permettono di creare un nuovo esercizio. Vengono definite le impostazioni di base, il titolo, il testo e un’eventuale immagine. La seguente parte di XML è utile per creare del testo di suggerimento che viene mostrato quando il campo è vuoto e viene usato per il titolo e per il testo.

```xml
<!-- Titolo esercizio -->
<TextBox x:Name="titoloTextBox" Grid.Column="0" Grid.Row="0" />
<!-- Placeholder -->
<TextBlock IsHitTestVisible="False" Text="Titolo esercizio..." 
           VerticalAlignment="Center" Foreground="DarkGray" Margin="10 0 0 0">
    <TextBlock.Style>
        <Style TargetType="{x:Type TextBlock}">
            <Setter Property="Visibility" Value="Collapsed"/>
            <Style.Triggers>
                <DataTrigger Binding="{Binding Text, ElementName=titoloTextBox}" Value="">
                    <Setter Property="Visibility" Value="Visible"/>
                </DataTrigger>
            </Style.Triggers>
        </Style>
    </TextBlock.Style>
</TextBlock>
```

<div style="page-break-after: always;"></div>

Poi grazie alle indicazioni del docente sono riuscito a mostrare le liste di tematiche e esercizi nella sezione dei moduli nell'ImpostazioniBaseViewModel. Infatti ho dovuto aggiungere una proprietà non mappata nel Model del modulo in cui ritorno la lista sotto forma di stringa.

```c#
public virtual ICollection<Tematica> Tematiche { get; set; }
[NotMapped]
public string TematicheList => string.Join(", ", Tematiche);
public virtual ICollection<Esercizio> Esercizi { get; set; }
[NotMapped]
public string EserciziList => string.Join(", ", Esercizi);
```

Il prossimo passo sarà cercare di mostrare solo delle colonne specifiche nel DataGrid (anche per questo ho un'idea della soluzione). 

| Orario | Lavori svolti |
| - | - |
|13:15 - 16:30 | Implementazione e Documentazione |

## Problemi riscontrati e soluzioni adottate

Nessun problema riscontrato.

## Punto della situazione rispetto alla pianificazione

In linea con la pianificazione.

## Programma di massima per la prossima giornata di lavoro

Implementazione, documentazione.
