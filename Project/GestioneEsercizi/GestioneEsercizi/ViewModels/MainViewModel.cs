using MVVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestioneEsercizi.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public IDelegateCommand CoffeeListCommand { get; set; }

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
        }

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
    }
}
