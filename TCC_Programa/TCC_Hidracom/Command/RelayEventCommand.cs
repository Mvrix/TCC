using System;
using System.Windows.Input;

namespace TCC_Hidracom
{
    public class RelayEventCommand : ICommand
    {
        Predicate<object> m_canExecute;
        Action<object> m_execute;
        bool m_defaultBehaviourForCanExecute;

        public RelayEventCommand(Action<object> execute, bool defaultBehaviourForCanExecute = true, Predicate<object> canExecute = null)
        {
            m_canExecute = canExecute;
            m_execute = execute;
            m_defaultBehaviourForCanExecute = defaultBehaviourForCanExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (m_canExecute != null)
            {
                //Logger.LogInformation("Evaluating can execute method for " + _canExecute.Method.DeclaringType + "->" + _canExecute.Method.Name);
                return m_canExecute.Invoke(parameter);
            }
            return m_defaultBehaviourForCanExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public void Execute(object parameter)
        {
            //Logger.LogInformation("Executing command method for " + _execute.Method.DeclaringType + "->" + _execute.Method.Name);
            m_execute.Invoke(parameter);
            RaiseCanExecuteChanged();
        }
    }
}
