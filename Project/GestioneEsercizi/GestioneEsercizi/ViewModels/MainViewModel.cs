using MVVM;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel principale in cui vengono gestiti gli altri ViewModels
    /// e viene impostato quello da usare tramite i Commands e la 
    /// proprietà CurrentViewModel.
    /// </summary>
    public class MainViewModel : BindableBase
    {
        /// <summary>
        /// Campo che rappresenta il ViewModel della schermata di benvenuto.
        /// </summary>
        private BenvenutoViewModel benvenutoViewModel;
        /// <summary>
        /// Campo che rappresenta il ViewModel della schermata di informazioni.
        /// </summary>
        private AboutViewModel aboutViewModel;
        /// <summary>
        /// Campo che rappresenta il ViewModel della lista degli esercizi.
        /// </summary>
        private EsercizioListViewModel esercizioListViewModel;
        /// <summary>
        /// Campo che rappresenta il ViewModel della lista delle prove.
        /// </summary>
        private ProvaListViewModel provaListViewModel;
        /// <summary>
        /// Comando che porta alla schermata di informazioni.
        /// </summary>
        public IDelegateCommand AboutCommand { get; set; }
        /// <summary>
        /// Comando che porta alla lista degli esercizi.
        /// </summary>
        public IDelegateCommand EsercizioListCommand { get; set; }
        /// <summary>
        /// Comando che porta alla lista di prove.
        /// </summary>
        public IDelegateCommand ProvaListCommand { get; set; }
        /// <summary>
        /// Campo che rappresenta il ViewModel corrente.
        /// </summary>
        private BindableBase currentViewModel;
        /// <summary>
        /// Proprietà che rappresenta il ViewModel da mostrare nella MainView.
        /// </summary>
        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// Vengono impostati i ViewModels e Commands relativi.
        /// </summary>
        public MainViewModel()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            aboutViewModel = new AboutViewModel();
            esercizioListViewModel = new EsercizioListViewModel();
            provaListViewModel = new ProvaListViewModel();
            CurrentViewModel = benvenutoViewModel;
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            EsercizioListCommand = new DelegateCommand(OnEsercizioList, CanEsercizioList);
            ProvaListCommand = new DelegateCommand(OnProvaList, CanProvaList);
            // Ricezione dei messaggi da parte degli altri ViewModels.
            Messenger.Default.Register<BindableBase>(this, OnViewModelReceived);
        }
        /// <summary>
        /// Impostazione del ViewModel tramite la ricezione del messaggio.
        /// </summary>
        /// <param name="viewmodel">ViewModel da impostare.</param>
        public void OnViewModelReceived(BindableBase viewmodel) => CurrentViewModel = viewmodel;
        private void OnBenvenuto(object obj) => CurrentViewModel = benvenutoViewModel;
        private bool CanBenvenuto(object arg) => true;
        private void OnAbout(object obj) => CurrentViewModel = aboutViewModel;
        private bool CanAbout(object arg) => true;
        private void OnEsercizioList(object obj) => CurrentViewModel = esercizioListViewModel;
        private bool CanEsercizioList(object arg) => true;
        private void OnProvaList(object obj) => CurrentViewModel = provaListViewModel;
        private bool CanProvaList(object arg) => true;
    }
}