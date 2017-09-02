
using System;
using System.Windows.Input;

namespace LegacyCodeChanger
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            bool canExecute = true;
            if (parameter == null)
            {
                return canExecute;
            }

            try
            {
                canExecute = (bool)parameter;
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR! /n {0}", ex);
            }
            return canExecute;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        private Action _action;
    }
}
