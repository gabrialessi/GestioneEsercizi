using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private ClasseViewModel classevm;

        public IDelegateCommand ClasseListCommand { get; set; }

        private BindableBase currentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }

        public MainViewModel()
        {
            RegisterCommands();
        }

        private void RegisterCommands()
        {
            ClasseListCommand = new DelegateCommand(OnClasseList, CanClasseList);
        }

        private void OnClasseList(object obj)
        {
            CurrentViewModel = classevm;
        }

        private bool CanClasseList(object arg)
        {
            return true;
        }
    }
}
