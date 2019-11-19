using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    public partial class EsercizioView : UserControl
    {
        public EsercizioView() => InitializeComponent();
        /// <summary>
        /// Ricerca del file tramite explorer sul click del pulsante.
        /// </summary>
        private void sfogliaButtonClick(object sender, RoutedEventArgs e)
        {
            // Creazione File Explorer
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Impostazione estensioni files
            dlg.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif";
            // Mostrare il file selezionato nella label
            if (dlg.ShowDialog() == true) SetLabelContent(dlg.FileName);
        }
        /// <summary>
        /// Drag&Drop dell'immagine.
        /// </summary>
        private void ImageDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                SetLabelContent(files[0]);
            }
        }
        /// <summary>
        /// Impostazione del nome dell'immagine selezionata sul Label.
        /// </summary>
        /// <param name="filename">Nome del file.</param>
        private void SetLabelContent(string filename) => immagineLabel.Content = Path.GetFileName(filename);
    }
}