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
        public EsercizioViewModel()
        {
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            AppDbContext ctx = new AppDbContext();
            ClasseDbRepository repoClasse = new ClasseDbRepository(ctx);
            ModuloDbRepository repoModulo = new ModuloDbRepository(ctx);
            TematicaDbRepository repoTematica = new TematicaDbRepository(ctx);
            Classi = new ObservableCollection<Classe>(repoClasse.Get());
            Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
            Tematiche = new ObservableCollection<Tematica>(repoTematica.Get());
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
    }
}