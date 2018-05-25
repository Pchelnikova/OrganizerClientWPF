using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OrganizerClientWPF
{
    class DelegateCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;
        private Action<object, RoutedEventArgs> add_Click_Profits;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> execute)
                       : this(execute, null)
        {
        }

        public DelegateCommand(Action<object> execute,
                       Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public DelegateCommand(Action<object, RoutedEventArgs> add_Click_Profits)
        {
            this.add_Click_Profits = add_Click_Profits;
        }

        public void Execute(object param)
        {
            _execute(param);
        }
        public bool CanExecute(object param)
        {
            return _canExecute(param);
        }
        private bool AlwaysCanExecute(object param)
        {
            return true;
        }       

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}
