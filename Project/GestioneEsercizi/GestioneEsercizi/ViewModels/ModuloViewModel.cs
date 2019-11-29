using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    public class ModuloViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Comando che salva il modulo inserito.
        /// </summary>
        public IDelegateCommand SalvaCommand { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati degli anni.
        /// </summary>
        public ObservableCollection<Anno> Anni { get; set; }
        /// <summary>
        /// Nome del modulo da aggiungere.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Anno del modulo da aggiungere.
        /// </summary>
        public Anno Anno { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ModuloViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            SalvaCommand = new DelegateCommand(OnSalva, CanSalva);
            AnnoDbRepository repo = new AnnoDbRepository(new AppDbContext());
            Anni = new ObservableCollection<Anno>(repo.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
        private void OnSalva(object obj)
        {
            ModuloDbRepository repo = new ModuloDbRepository(new AppDbContext());
            // Aggiungo il modulo
            repo.Insert(new Modulo(Nome, Anno));
            OnBenvenuto(obj);
        }
        private bool CanSalva(object arg) => true;
    }
}