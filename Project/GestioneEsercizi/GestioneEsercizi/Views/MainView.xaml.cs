using System.Windows;
using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    public partial class MainView : UserControl
    {
        public MainView() => InitializeComponent();
        /// <summary>
        /// Chiusura dell'applicazione.
        /// </summary>
        private void Exit(object sender, RoutedEventArgs e)
            => System.Windows.Application.Current.Shutdown();
    }
}