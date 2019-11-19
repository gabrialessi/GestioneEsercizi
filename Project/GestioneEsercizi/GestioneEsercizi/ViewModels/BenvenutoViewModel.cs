using MVVM;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata di benvenuto.
    /// </summary>
    public class BenvenutoViewModel : BindableBase
    {
        private ImpostazioniBaseViewModel impostazionibaseViewModel;
        private EsercizioViewModel esercizioViewModel;
        private ProvaViewModel provaViewModel;
        public IDelegateCommand ImpostazioniBaseCommand { get; set; }
        public IDelegateCommand EsercizioCommand { get; set; }
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