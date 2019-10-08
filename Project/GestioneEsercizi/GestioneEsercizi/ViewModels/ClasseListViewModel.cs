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
    public class ClasseListViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati delle classi.
        /// </summary>
        public ObservableCollection<Classe> Classi { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ClasseListViewModel()
        {
            ClasseDbRepository repo = new ClasseDbRepository(new AppDbContext());
            Classi = new ObservableCollection<Classe>(repo.Get());
        }
    }
}
