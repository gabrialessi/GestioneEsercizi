using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata della lista di esercizi memorizzati.
    /// </summary>
    public class EsercizioListViewModel : BindableBase
    {
        /// <summary>
        /// Campo che rappresenta il ViewModel della schermata di benvenuto.
        /// </summary>
        private BenvenutoViewModel benvenutoViewModel;
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
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
            benvenutoViewModel = new BenvenutoViewModel();
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            EsercizioDbRepository repo = new EsercizioDbRepository(new AppDbContext());
            Esercizi = new ObservableCollection<Esercizio>(repo.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(benvenutoViewModel);
        private bool CanBenvenuto(object arg) => true;
    }
}