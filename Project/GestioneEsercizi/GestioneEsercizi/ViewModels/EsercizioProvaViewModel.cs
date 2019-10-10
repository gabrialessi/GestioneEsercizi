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
    public class EsercizioProvaViewModel : BindableBase
    {
        /// <summary>
        /// Insieme dinamico dei dati degli esercizi della prova.
        /// </summary>
        public ObservableCollection<EsercizioProva> EserciziProva { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public EsercizioProvaViewModel()
        {
            EsercizioProvaDbRepository repo = new EsercizioProvaDbRepository(new AppDbContext());
            EserciziProva = new ObservableCollection<EsercizioProva>(repo.Get());
        }
    }
}
