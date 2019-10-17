using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private AboutViewModel aboutvm;

        public IDelegateCommand AboutCommand { get; set; }

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
            CurrentViewModel = null;
        }

        private void RegisterCommands()
        {
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
        }

        private bool CanAbout(object arg)
        {
            return true;
        }

        private void OnAbout(object obj)
        {
            CurrentViewModel = aboutvm;
        }
    }
}
