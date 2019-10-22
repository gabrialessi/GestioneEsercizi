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
        private ImpostazioniBaseViewModel impostazionibasevm;
        private EsercizioViewModel eserciziovm;
        private ProvaViewModel provavm;

        public IDelegateCommand BenvenutoCommand { get; set; }
        public IDelegateCommand AboutCommand { get; set; }
        public IDelegateCommand ImpostazioniBaseCommand { get; set; }
        public IDelegateCommand EsercizioCommand { get; set; }
        public IDelegateCommand ProvaCommand { get; set; }

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
            impostazionibasevm = new ImpostazioniBaseViewModel();
            eserciziovm = new EsercizioViewModel();
            provavm = new ProvaViewModel();
            CurrentViewModel = benvenutovm;
        }

        private void RegisterCommands()
        {
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
            ImpostazioniBaseCommand = new DelegateCommand(OnImpostazioniBase, CanImpostazioniBase);
            EsercizioCommand = new DelegateCommand(OnEsercizio, CanEsercizio);
            ProvaCommand = new DelegateCommand(OnProva, CanProva);
        }

        private void OnBenvenuto(object obj) { CurrentViewModel = benvenutovm; }
        private bool CanBenvenuto(object arg) { return true; }
        private void OnAbout(object obj) { CurrentViewModel = aboutvm; }
        private bool CanAbout(object arg) { return true; }
        private void OnImpostazioniBase(object obj) { CurrentViewModel = impostazionibasevm; }
        private bool CanImpostazioniBase(object arg) { return true; }
        private void OnEsercizio(object obj) { CurrentViewModel = eserciziovm; }
        private bool CanEsercizio(object arg) { return true; }
        private void OnProva(object obj) { CurrentViewModel = provavm; }
        private bool CanProva(object arg) { return true; }
    }
}