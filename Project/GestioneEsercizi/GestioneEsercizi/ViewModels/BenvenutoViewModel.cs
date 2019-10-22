using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class BenvenutoViewModel : BindableBase
    {
        private ImpostazioniBaseViewModel impostazionibasevm;
        private EsercizioViewModel eserciziovm;
        private ProvaViewModel provavm;

        public IDelegateCommand ImpostazioniBaseCommand { get; set; }
        public IDelegateCommand EsercizioCommand { get; set; }
        public IDelegateCommand ProvaCommand { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public BenvenutoViewModel()
        {
            impostazionibasevm = new ImpostazioniBaseViewModel();
            eserciziovm = new EsercizioViewModel();
            provavm = new ProvaViewModel();
        }

        private void RegisterCommands()
        {
            ImpostazioniBaseCommand = new DelegateCommand(OnImpostazioniBase, CanImpostazioniBase);
            EsercizioCommand = new DelegateCommand(OnEsercizio, CanEsercizio);
            ProvaCommand = new DelegateCommand(OnProva, CanProva);
        }

        private void OnImpostazioniBase(object obj) { CurrentViewModel = impostazionibasevm; }
        private bool CanImpostazioniBase(object arg) { return true; }
        private void OnEsercizio(object obj) { CurrentViewModel = eserciziovm; }
        private bool CanEsercizio(object arg) { return true; }
        private void OnProva(object obj) { CurrentViewModel = provavm; }
        private bool CanProva(object arg) { return true; }
    }
}
