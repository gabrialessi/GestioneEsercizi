using MVVM;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata relativa alle informazioni del prodotto.
    /// </summary>
    public class AboutViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public AboutViewModel() => BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
    }
}