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
    public class TematicaListViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati delle tematiche.
        /// </summary>
        public ObservableCollection<Tematica> Tematiche { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public TematicaListViewModel()
        {
            TematicaDbRepository repo = new TematicaDbRepository(new AppDbContext());
            Tematiche = new ObservableCollection<Tematica>(repo.Get());
        }
    }
}
