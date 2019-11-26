using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    public class EsercizioViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Comando che salva l'esercizio fatto.
        /// </summary>
        public IDelegateCommand SalvaCommand { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati dei moduli.
        /// </summary>
        public ObservableCollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Titolo dell'esercizio da aggiungere.
        /// </summary>
        public string Titolo { get; set; }
        /// <summary>
        /// Testo dell'esercizio da aggiungere.
        /// </summary>
        public string Testo { get; set; }
        /// <summary>
        /// Modulo dell'esercizio da aggiungere.
        /// </summary>
        public Modulo Modulo { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public EsercizioViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            SalvaCommand = new DelegateCommand(OnSalva, CanSalva);
            ModuloDbRepository repoModulo = new ModuloDbRepository(new AppDbContext());
            Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
        private void OnSalva(object obj)
        {
            EsercizioDbRepository repoEsercizio = new EsercizioDbRepository(new AppDbContext());
            // Aggiungo l'esercizio
            repoEsercizio.Insert(new Esercizio(Titolo, Testo, Modulo));
            OnBenvenuto(obj);
        }
        private bool CanSalva(object arg) => true;
    }
}