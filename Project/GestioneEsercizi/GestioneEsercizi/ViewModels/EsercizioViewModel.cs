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
    public class EsercizioViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati degli esercizi.
        /// </summary>
        public ObservableCollection<Esercizio> Esercizi { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public EsercizioViewModel()
        {
            EsercizioDbRepository repo = new EsercizioDbRepository(new AppDbContext());
            Esercizi = new ObservableCollection<Esercizio>(repo.Get());
        }
    }
}
