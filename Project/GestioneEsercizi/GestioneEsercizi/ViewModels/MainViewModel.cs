using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private AboutViewModel aboutvm;
        private BenvenutoViewModel benvenutovm;
        private ImpostazioniBaseViewModel impostazionibasevm;

        public IDelegateCommand AboutCommand { get; set; }
        public IDelegateCommand BenvenutoCommand { get; set; }
        public IDelegateCommand ImpostazioniBaseCommand { get; set; }

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        public MainViewModel()
        {
            RegisterCommands();
            aboutvm = new AboutViewModel();
            benvenutovm = new BenvenutoViewModel();
            impostazionibasevm = new ImpostazioniBaseViewModel();
            CurrentViewModel = benvenutovm;
        }

        private void RegisterCommands()
        {
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            ImpostazioniBaseCommand = new DelegateCommand(OnImpostazioniBase, CanImpostazioniBase);
        }

        private void OnAbout(object obj)
        {
            CurrentViewModel = aboutvm;
        }

        private bool CanAbout(object arg)
        {
            return true;
        }

        private void OnBenvenuto(object obj)
        {
            CurrentViewModel = benvenutovm;
        }

        private bool CanBenvenuto(object arg)
        {
            return true;
        }

        private void OnImpostazioniBase(object obj)
        {
            CurrentViewModel = impostazionibasevm;
        }

        private bool CanImpostazioniBase(object arg)
        {
            return true;
        }
    }
}
