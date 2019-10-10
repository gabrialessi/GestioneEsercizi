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
    public class ProvaViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati delle prove.
        /// </summary>
        public ObservableCollection<Prova> Prove { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ProvaViewModel()
        {
            ProvaDbRepository repo = new ProvaDbRepository(new AppDbContext());
            Prove = new ObservableCollection<Prova>(repo.Get());
        }
    }
}
