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
    public class ModuloViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati dei moduli.
        /// </summary>
        public ObservableCollection<Modulo> Moduli { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ModuloViewModel()
        {
            ModuloDbRepository repo = new ModuloDbRepository(new AppDbContext());
            Moduli = new ObservableCollection<Modulo>(repo.Get());
        }
    }
}
