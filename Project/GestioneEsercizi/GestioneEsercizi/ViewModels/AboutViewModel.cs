using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class AboutViewModel : BindableBase
    {
        private BenvenutoViewModel benvenutoViewModel;

        public IDelegateCommand BenvenutoCommand { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public AboutViewModel()
        {
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        }

        private void OnBenvenuto(object obj) { Messenger.Default.Send<BindableBase>(benvenutoViewModel); }
        private bool CanBenvenuto(object arg) { return true; }
    }
}
