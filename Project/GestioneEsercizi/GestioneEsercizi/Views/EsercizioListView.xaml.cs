using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestioneEsercizi.Views
{
    /// <summary>
    /// Interaction logic for EsercizioListView.xaml
    /// </summary>
    public partial class EsercizioListView : UserControl
    {
        public EsercizioListView()
        {
            InitializeComponent();
            //dgEsercizi.Columns[1].Visibility = Visibility.Collapsed;
            //dgEsercizi.Columns[3].Visibility = Visibility.Collapsed;
            //dgEsercizi.Columns[4].Visibility = Visibility.Collapsed;
        }
    }
}
