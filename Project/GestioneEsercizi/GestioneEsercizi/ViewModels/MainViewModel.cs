using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private BenvenutoViewModel benvenutovm;
        private AboutViewModel aboutvm;

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
            benvenutovm = new BenvenutoViewModel();
            aboutvm = new AboutViewModel();
            CurrentViewModel = benvenutovm;
        }

        private void RegisterCommands()
        {
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        }

        private void OnBenvenuto(object obj) { CurrentViewModel = benvenutovm; }
        private bool CanBenvenuto(object arg) { return true; }
        private void OnAbout(object obj) { CurrentViewModel = aboutvm; }
        private bool CanAbout(object arg) { return true; }
    }
}