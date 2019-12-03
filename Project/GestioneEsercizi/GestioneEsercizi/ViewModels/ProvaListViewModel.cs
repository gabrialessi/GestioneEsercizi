using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata della lista delle prove memorizzate.
    /// </summary>
    public class ProvaListViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Lista di prove.
        /// </summary>
        public ObservableCollection<Prova> Prove { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ProvaListViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            ProvaDbRepository repo = new ProvaDbRepository(new AppDbContext());
            Prove = new ObservableCollection<Prova>(repo.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
    }
}