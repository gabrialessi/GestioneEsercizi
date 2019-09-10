using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM;
using System.Windows;
using _09_RSI.Service;

namespace _09_RSI.ViewModel
{
    public class MainViewModel : BindableBase
    {
        #region =================== costanti ===================
        #endregion

        #region =================== membri statici =============
        #endregion

        #region =================== membri & proprietà =========
        private BindableBase currentViewModelBase;
        public BindableBase CurrentViewModel
        {
            get { return currentViewModelBase; }
            set
            {
                SetProperty(ref currentViewModelBase, value);
            }
        }
        public IDelegateCommand AboutCommand { get; private set; }
        public IDelegateCommand ShutdownCommand { get; private set; }
        public IDelegateCommand ScheduleCommand { get; private set; }
        #endregion

        #region =================== costruttori ================

        public MainViewModel()
        {
            RegisterCommands();
            CurrentViewModel = ViewModelLocator.About;
        }

        #endregion

        #region =================== metodi aiuto ===============
        private void RegisterCommands()
        {
            AboutCommand = new DelegateCommand(OnAbout, CanAbout);
            ShutdownCommand = new DelegateCommand(OnShutdown);
            ScheduleCommand = new DelegateCommand(OnSchedule, CanSchedule);
        }

        private void OnShutdown(object obj)
        {
            ShutdownService.RequestShutdown();
        }

        private bool CanAbout(object arg)
        {
            return true;
        }

        private void OnAbout(object obj)
        {
            CurrentViewModel = ViewModelLocator.About;
        }

        private bool CanSchedule(object arg)
        {
            return true;
        }

        private void OnSchedule(object obj)
        {
            CurrentViewModel = ViewModelLocator.ScheduleList;
        }

        #endregion

        #region =================== metodi generali ============
        #endregion
    }
}
