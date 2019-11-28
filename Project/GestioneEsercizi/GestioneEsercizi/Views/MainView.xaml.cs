using System.Windows;
using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    public partial class MainView : UserControl
    {
        public MainView() => InitializeComponent();
        private void miEsci_Click(object sender, RoutedEventArgs e)
            => System.Windows.Application.Current.Shutdown();
    }
}