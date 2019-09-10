using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_CoffeeShop.ViewModel
{
    public class MainViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private CoffeeListViewModel clvm;
        private AboutViewModel avm;

        public IDelegateCommand CoffeeListCommand { get; set; }

        public IDelegateCommand AboutCommand { get; set; }

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        #endregion

        #region =================== costruttori ================
        public MainViewModel()
        {
            RegisterCommands();
            clvm = new CoffeeListViewModel();
            avm = new AboutViewModel();
            CurrentViewModel = clvm;
        }
        #endregion

        #region =================== metodi aiuto ===============
        private void RegisterCommands()
        {
            CoffeeListCommand = new DelegateCommand(OnCoffeeList, CanCoffeeList);
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
        }

        private bool CanAbout(object arg)
        {
            return true;
        }

        private void OnAbout(object obj)
        {
            CurrentViewModel = avm;
        }

        private bool CanCoffeeList(object arg)
        {
            return true;
        }

        private void OnCoffeeList(object obj)
        {
            CurrentViewModel = clvm;
        }
        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
