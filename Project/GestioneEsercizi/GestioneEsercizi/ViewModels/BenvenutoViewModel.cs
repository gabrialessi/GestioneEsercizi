using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class BenvenutoViewModel : BindableBase
    {
        private ImpostazioniBaseViewModel impostazionibaseViewModel;
        private EsercizioViewModel esercizioViewModel;
        private ProvaViewModel provaViewModel;

        public IDelegateCommand ImpostazioniBaseCommand { get; set; }
        public IDelegateCommand EsercizioCommand { get; set; }
        public IDelegateCommand ProvaCommand { get; set; }

        private BindableBase selectedViewModel;
        public BindableBase SelectedViewModel
        {
            get { return selectedViewModel; }
            set { SetProperty(ref selectedViewModel, value); }
        }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public BenvenutoViewModel()
        {
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            impostazionibaseViewModel = new ImpostazioniBaseViewModel();
            esercizioViewModel = new EsercizioViewModel();
            provaViewModel = new ProvaViewModel();
            ImpostazioniBaseCommand = new DelegateCommand(OnImpostazioniBase, CanImpostazioniBase);
            EsercizioCommand = new DelegateCommand(OnEsercizio, CanEsercizio);
            ProvaCommand = new DelegateCommand(OnProva, CanProva);
        }

        private void EditCurrentViewModel(object obj)
        {
            Messenger.Default.Send<BindableBase>(selectedViewModel);
        }

        private void OnImpostazioniBase(object obj) { SelectedViewModel = impostazionibaseViewModel; }
        private bool CanImpostazioniBase(object arg) { return true; }
        private void OnEsercizio(object obj) { SelectedViewModel = esercizioViewModel; }
        private bool CanEsercizio(object arg) { return true; }
        private void OnProva(object obj) { SelectedViewModel = provaViewModel; }
        private bool CanProva(object arg) { return true; }
    }
}
