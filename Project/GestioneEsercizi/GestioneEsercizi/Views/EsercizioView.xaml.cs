using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GestioneEsercizi.Views
{
    public partial class EsercizioView : UserControl
    {
        public EsercizioView() => InitializeComponent();
        /// <summary>
        /// Ricerca del file tramite explorer sul click del pulsante.
        /// </summary>
        private void Sfoglia(object sender, RoutedEventArgs e)
        {
            // Creazione File Explorer
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Impostazione estensioni files
            dlg.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif";
            // Mostrare il file selezionato
            if (dlg.ShowDialog() == true) SetImage(dlg.FileName);

        }
        /// <summary>
        /// Drag&Drop dell'immagine.
        /// </summary>
        private void ImageDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                SetImage(files[0]);
            }
        }
        /// <summary>
        /// Impostazione della sorgente dell'immagine selezionata.
        /// </summary>
        /// <param name="filename">Nome del file.</param>
        private void SetImage(string filename)
            => immagine.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));
    }
}