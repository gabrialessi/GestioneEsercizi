using System.Diagnostics;
using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    public partial class AboutView : UserControl
    {
        public AboutView() => InitializeComponent();
        private void NavigateWebsite(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
                e.Handled = true;
            }
            catch (System.ComponentModel.Win32Exception) { }
        }
    }
}