using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class AnnoViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati degli anni.
        /// </summary>
        public ObservableCollection<Anno> Anni { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public AnnoViewModel()
        {
            AnnoDbRepository repo = new AnnoDbRepository(new AppDbContext());
            Anni = new ObservableCollection<Anno>(repo.Get());
        }
    }
}
