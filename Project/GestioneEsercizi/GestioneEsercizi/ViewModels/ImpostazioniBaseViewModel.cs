using GestioneEsercizi.DA;
using GestioneEsercizi.DA.Models;
using GestioneEsercizi.DA.Services;
using MVVM;
using System.Collections.ObjectModel;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel delle impostazioni di base.
    /// </summary>
    public class ImpostazioniBaseViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Comando che porta all'aggiunta di una nuova classe.
        /// </summary>
        public IDelegateCommand ClasseCommand { get; set; }
        /// <summary>
        /// Comando che porta all'aggiunta di un nuova modulo.
        /// </summary>
        public IDelegateCommand ModuloCommand { get; set; }
        /// <summary>
        /// Comando che porta all'aggiunta di una nuova tematica.
        /// </summary>
        public IDelegateCommand TematicaCommand { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati delle classi.
        /// </summary>
        public ObservableCollection<Classe> Classi { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati dei moduli.
        /// </summary>
        public ObservableCollection<Modulo> Moduli { get; set; }
        /// <summary>
        /// Insieme dinamico dei dati delle tematiche.
        /// </summary>
        public ObservableCollection<Tematica> Tematiche { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public ImpostazioniBaseViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            ClasseCommand = new DelegateCommand(OnBenvenuto, CanClasse);
            ModuloCommand = new DelegateCommand(OnBenvenuto, CanModulo);
            TematicaCommand = new DelegateCommand(OnBenvenuto, CanTematica);
            AppDbContext ctx = new AppDbContext();
            ClasseDbRepository repoClasse = new ClasseDbRepository(ctx);
            ModuloDbRepository repoModulo = new ModuloDbRepository(ctx);
            TematicaDbRepository repoTematica = new TematicaDbRepository(ctx);
            Classi = new ObservableCollection<Classe>(repoClasse.Get());
            Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
            Tematiche = new ObservableCollection<Tematica>(repoTematica.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private void OnClasse(object obj) => Messenger.Default.Send<BindableBase>(new ClasseViewModel());
        private void OnModulo(object obj) => Messenger.Default.Send<BindableBase>(new ModuloViewModel());
        private void OnTematica(object obj) => Messenger.Default.Send<BindableBase>(new TematicaViewModel());
        private bool CanBenvenuto(object arg) => true;
        private bool CanClasse(object arg) => true;
        private bool CanModulo(object arg) => true;
        private bool CanTematica(object arg) => true;
    }
}