using MVVM;

namespace GestioneEsercizi.ViewModels
{
    /// <summary>
    /// ViewModel della schermata relativa alla guida del prodotto.
    /// </summary>
    public class GuidaViewModel : BindableBase
    {
        /// <summary>
        /// Comando che porta alla schermata di benvenuto.
        /// </summary>
        public IDelegateCommand BenvenutoCommand { get; set; }
        /// <summary>
        /// Metodo costruttore del ViewModel.
        /// </summary>
        public GuidaViewModel() => BenvenutoCommand = new DelegateCommand(OnBenvenuto, CanBenvenuto);
        private void OnBenvenuto(object obj) => Messenger.Default.Send<BindableBase>(new BenvenutoViewModel());
        private bool CanBenvenuto(object arg) => true;
    }
}