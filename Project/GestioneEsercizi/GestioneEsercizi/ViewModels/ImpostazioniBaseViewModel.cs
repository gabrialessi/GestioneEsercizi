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
        /// Campo che rappresenta il ViewModel della schermata di benvenuto.
        /// </summary>
        private BenvenutoViewModel benvenutoViewModel;
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
        public ImpostazioniBaseViewModel()
        {
            AppDbContext ctx = new AppDbContext();
            ClasseDbRepository repoClasse = new ClasseDbRepository(ctx);
            ModuloDbRepository repoModulo = new ModuloDbRepository(ctx);
            TematicaDbRepository repoTematica = new TematicaDbRepository(ctx);
            Classi = new ObservableCollection<Classe>(repoClasse.Get());
            Moduli = new ObservableCollection<Modulo>(repoModulo.Get());
            Tematiche = new ObservableCollection<Tematica>(repoTematica.Get());
            //benvenutoViewModel = new BenvenutoViewModel();
            //BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(benvenutoViewModel);
        private bool CanBenvenuto(object arg) => true;
    }
}
