using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using System;
using System.Linq;
using System.Windows;

namespace GestioneEsercizi
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AnnoDbRepository repo = new AnnoDbRepository(new AppDbContext());
            string anno = DateTime.Today.Year.ToString()
                    + "/" + (DateTime.Today.Year + 1).ToString();
            try
            {
                if (repo.Get().FirstOrDefault().Annata != anno) repo.Insert(new Anno(anno));
            }
            catch (NullReferenceException)
            {
                repo.Insert(new Anno(anno));
            }
        }
    }
}