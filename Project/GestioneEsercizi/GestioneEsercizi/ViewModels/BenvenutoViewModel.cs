using MVVM;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata di benvenuto.
    /// </summary>
    public class BenvenutoViewModel : BindableBase
    {
        /// <summary>
        /// Campo che rappresenta il ViewModel delle impostazioni di base.
        /// </summary>
        private ImpostazioniBaseViewModel impostazionibaseViewModel;
        /// <summary>
        /// Campo che rappresenta il ViewModel dell'esercizio.
        /// </summary>
        private EsercizioViewModel esercizioViewModel;
        /// <summary>
        /// Campo che rappresenta il ViewModel della creazione prova.
        /// </summary>
        private ProvaViewModel provaViewModel;
        /// <summary>
        /// Comando che porta alle impostazioni di base.
        /// </summary>
        public IDelegateCommand ImpostazioniBaseCommand { get; set; }
        /// <summary>
        /// Comando che porta alla creazione di un esercizio.
        /// </summary>
        public IDelegateCommand EsercizioCommand { get; set; }
        /// <summary>
        /// Comando che porta alla creazione di una prova.
        /// </summary>
        public IDelegateCommand ProvaCommand { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public BenvenutoViewModel()
        {
            impostazionibaseViewModel = new ImpostazioniBaseViewModel();
            esercizioViewModel = new EsercizioViewModel();
            provaViewModel = new ProvaViewModel();
            ImpostazioniBaseCommand = new DelegateCommand(OnImpostazioniBase, CanImpostazioniBase);
            EsercizioCommand = new DelegateCommand(OnEsercizio, CanEsercizio);
            ProvaCommand = new DelegateCommand(OnProva, CanProva);
        }
        private void OnImpostazioniBase(object obj) => Messenger.Default.Send<BindableBase>(impostazionibaseViewModel);
        private bool CanImpostazioniBase(object arg) => true;
        private void OnEsercizio(object obj) => Messenger.Default.Send<BindableBase>(esercizioViewModel);
        private bool CanEsercizio(object arg) => true;
        private void OnProva(object obj) => Messenger.Default.Send<BindableBase>(provaViewModel);
        private bool CanProva(object arg) => true;
    }
}