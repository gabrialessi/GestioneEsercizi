using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private BenvenutoViewModel benvenutoViewModel;
        private AboutViewModel aboutViewModel;

        public IDelegateCommand BenvenutoCommand { get; set; }
        public IDelegateCommand AboutCommand { get; set; }

        private BindableBase currentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        public MainViewModel()
        {
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            aboutViewModel = new AboutViewModel();
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            CurrentViewModel = benvenutoViewModel;
        }

        private void RegisterMessages()
        {
            Messenger.Default.Register<BindableBase>(this, OnCurrentViewModelReceived);
        }

        private void OnBenvenuto(object obj) { CurrentViewModel = benvenutoViewModel; }
        private bool CanBenvenuto(object arg) { return true; }
        private void OnAbout(object obj) { CurrentViewModel = aboutViewModel; }
        private bool CanAbout(object arg) { return true; }
        public void OnCurrentViewModelReceived(BindableBase viewmodel) { CurrentViewModel = viewmodel; }
    }
}