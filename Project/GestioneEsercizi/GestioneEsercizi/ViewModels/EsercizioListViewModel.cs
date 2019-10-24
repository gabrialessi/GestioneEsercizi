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
    /// <summary>
    /// ViewModel della schermata della lista di esercizi memorizzati.
    /// </summary>
    public class EsercizioListViewModel : BindableBase
    {
        private BenvenutoViewModel benvenutoViewModel;
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Lista di esercizi.
        /// </summary>
        public ObservableCollection<Esercizio> Esercizi { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public EsercizioListViewModel()
        {
            RegisterCommands();
            EsercizioDbRepository repo = new EsercizioDbRepository(new AppDbContext());
            Esercizi = new ObservableCollection<Esercizio>(repo.Get());
        }

        /// <summary>
        /// Impostazione dei ViewModels e Commands relativi.
        /// </summary>
        private void RegisterCommands()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        }

        private void OnBenvenuto(object obj) { Messenger.Default.Send<BindableBase>(benvenutoViewModel); }
        private bool CanBenvenuto(object arg) { return true; }
    }
}
