using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel per l'inserimento di una tematica.
    /// </summary>
    public class TematicaViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Comando che salva la tematica inserita.
        /// </summary>
        public IDelegateCommand SalvaCommand { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati dei moduli.
        /// </summary>
        public ObservableCollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Nome della tematica da aggiungere.
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Modulo della tematica da aggiungere.
        /// </summary>
        public Modulo Modulo { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public TematicaViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            SalvaCommand = new DelegateCommand(OnSalva, CanSalva);
            ModuloDbRepository repo = new ModuloDbRepository(new AppDbContext());
            Moduli = new ObservableCollection<Modulo>(repo.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
        private void OnSalva(object obj)
        {
            if (!string.IsNullOrWhiteSpace(Nome) && Modulo != null)
            {
                TematicaDbRepository repo = new TematicaDbRepository(new AppDbContext());
                // Aggiungo la tematica
                repo.Insert(new Tematica(Nome, Modulo));
                OnBenvenuto(obj);
            }
        }
        private bool CanSalva(object arg) => true;
    }
}