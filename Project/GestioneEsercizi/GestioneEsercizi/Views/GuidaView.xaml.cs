using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    public partial class GuidaView : UserControl
    {
        const string INTRODUZIONE =
            "Lo scopo di questo prodotto è quello di facilitare il lavoro dei docenti " +
            "permettendo di creare degli esercizi e delle prove in un sistema automatizzato. " +
            "L'applicazione presenta un menu dove è possibile vedere gli esercizi e le prove " +
            "salvati nel database e altre informazioni. Questo programma è stato sviluppato in " +
            "modo da essere semplice e veloce, tuttavia è necessario utilizzarlo nel modo giusto " +
            "seguendo appunto il resto di questa guida.";
        const string IMPOSTAZIONI_BASE =
            "Le informazioni presenti nelle impostazioni di base sono un elemento fondamentale " +
            "per il corretto funzionamento del prodotto. Infatti questi dati sono necessari per " +
            "la creazione di un nuovo esercizio e di conseguenza per la generazione di una prova.";
        const string ESERCIZIO =
            "Per fare un nuovo esercizio bisogna definire un titolo, scegliere il relativo modulo " +
            "e redigere il testo. Eventualmente si può scegliere un'immagine o trascinarla nel " +
            "riquadro ed essa verrà salvata venendo messa alla fine del testo dell'esercizio.";
        const string PROVA =
            "Il sistema di creazione delle prove è simile a quello degli esercizi, infatti bisogna " +
            "definire un titolo, scegliere una data, selezionare l'anno e infine valutare gli " +
            "esercizi da inserire prendendoli dalla lista.";
        public GuidaView()
        {
            InitializeComponent();
            introduzione.Text = INTRODUZIONE;
            impostazioniBase.Text = IMPOSTAZIONI_BASE;
            esercizio.Text = ESERCIZIO;
            prova.Text = PROVA;
        }
    }
}