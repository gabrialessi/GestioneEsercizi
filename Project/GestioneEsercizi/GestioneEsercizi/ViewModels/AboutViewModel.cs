using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata relativa alle informazioni del prodotto.
    /// </summary>
    public class AboutViewModel : BindableBase
    {
        private BenvenutoViewModel benvenutoViewModel;
        public IDelegateCommand BenvenutoCommand { get; set; }

        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public AboutViewModel() { RegisterCommands(); }

        /// <summary>
        /// Impostazione dei ViewModels e Commands relativi.
        /// </summary>
        private void RegisterCommands()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        }

        private void OnBenvenuto(object obj) { Messenger.Default.Send<BindableBase>(benvenutoViewModel); }
        private bool CanBenvenuto(object arg) { return true; }
    }
}
