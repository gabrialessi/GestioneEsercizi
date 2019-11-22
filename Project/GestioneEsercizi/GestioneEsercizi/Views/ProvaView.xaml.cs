using System;
using System.Windows.Controls;

namespace GestioneEsercizi.Views
{
    public partial class ProvaView : UserControl
    {
        public ProvaView()
        {
            InitializeComponent();
            dataDatePicker.DisplayDateStart = new DateTime(DateTime.Now.Year,
                                                           DateTime.Now.Month,
                                                           DateTime.Now.Day);
        }
    }
}