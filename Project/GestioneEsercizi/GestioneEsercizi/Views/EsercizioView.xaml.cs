using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    /// <summary>
    /// Interaction logic for EsercizioView.xaml
    /// </summary>
    public partial class EsercizioView : UserControl
    {
        public EsercizioView()
        {
            InitializeComponent();
        }
        private void bSfoglia_Click(object sender, RoutedEventArgs e)
        {
            // Creazione File Explorer
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            // Impostazione estensioni files
            dlg.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif";
            // Mostrare il file selezionato nella label
            if (dlg.ShowDialog() == true) SetLabelContent(dlg.FileName);
        }
        private void Image_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                SetLabelContent(files[0]);
            }
        }
        private void SetLabelContent(string filename) => lImmagine.Content = Path.GetFileName(filename);
    }
}