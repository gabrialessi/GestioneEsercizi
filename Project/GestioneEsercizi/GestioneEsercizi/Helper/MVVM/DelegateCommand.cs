using System;

namespace MVVM
{
    public class DelegateCommand : IDelegateCommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;
        // Evento richiesto da ICommand
        public event EventHandler CanExecuteChanged;
        // Construttore
        public DelegateCommand(Action<object> onExecute, Func<object, bool> canExecute = null)
        {
            this.execute = onExecute;
            this.canExecute = canExecute;
        }

        // Metodi richiesti da ICommand
        #region ICommand
        public void Execute(object parameter)
        {
            execute(parameter);
        }
        public bool CanExecute(object parameter)
        {
            bool b = canExecute == null ? true : canExecute(parameter);
            return b;
        }
        #endregion
        // Metodo richiesto da IDelegateCommand
        #region IDelegateCommand
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }
        #endregion
    }
}
