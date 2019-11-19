using MVVM;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata relativa alle informazioni del prodotto.
    /// </summary>
    public class AboutViewModel : BindableBase
    {
        /// <summary>
        /// Campo che rappresenta il ViewModel della schermata di benvenuto.
        /// </summary>
        private BenvenutoViewModel benvenutoViewModel;
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public AboutViewModel()
        {
            benvenutoViewModel = new BenvenutoViewModel();
            BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        }
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(benvenutoViewModel);
        private bool CanBenvenuto(object arg) => true;
    }
}