using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel principale in cui vengono gestiti gli altri ViewModels
    /// e viene impostato quello da usare tramite i Commands e la 
    /// proprietà CurrentViewModel.
    /// </summary>
    public class MainViewModel : BindableBase
    {
        private BenvenutoViewModel benvenutoViewModel;
        private AboutViewModel aboutViewModel;
        private EsercizioListViewModel esercizioListViewModel;
        public IDelegateCommand BenvenutoCommand { get; set; }
        public IDelegateCommand AboutCommand { get; set; }
        public IDelegateCommand EsercizioListCommand { get; set; }

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
        /// </summary>
        public MainViewModel() { RegisterCommands(); }

        private void RegisterCommands()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            aboutViewModel = new AboutViewModel();
            esercizioListViewModel = new EsercizioListViewModel();
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            EsercizioListCommand = new DelegateCommand(OnEsercizioList, CanEsercizioList);
            CurrentViewModel = benvenutoViewModel;
            RegisterMessages();
        }

        /// <summary>
        /// Ricezione dei messaggi da parte degli altri ViewModels.
        /// </summary>
        private void RegisterMessages()
        {
            Messenger.Default.Register<BindableBase>(this, OnViewModelReceived);
        }

        /// <summary>
        /// Impostazione del ViewModel tramite la ricezione del messaggio.
        /// </summary>
        /// <param name="viewmodel">ViewModel da impostare.</param>
        public void OnViewModelReceived(BindableBase viewmodel)
        {
            CurrentViewModel = viewmodel;
        }

        private void OnBenvenuto(object obj) { CurrentViewModel = benvenutoViewModel; }
        private bool CanBenvenuto(object arg) { return true; }
        private void OnAbout(object obj) { CurrentViewModel = aboutViewModel; }
        private bool CanAbout(object arg) { return true; }
        private void OnEsercizioList(object obj) { CurrentViewModel = esercizioListViewModel; }
        private bool CanEsercizioList(object arg) { return true; }
    }
}