using PropertyChanged;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TCC_Hidracom
{
    /// <summary>
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    [ImplementPropertyChanged]
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region Property Changed

        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        } 

        #endregion

        #region Command Helpers

        /// <summary>
        /// Runs a command if the updating flag is not set.
        /// If the flag is true (indicating the function is already running) then the action is not run.
        /// If the flag is false (indicating no running function) then the action is run.
        /// Once the action is finished if it was run, then the flag is reset to false
        /// </summary>
        /// <param name="updatingFlag">The boolean property flag defining if the command is already running</param>
        /// <param name="action">The action to run if the command is not already running</param>
        /// <returns></returns>
        protected async Task RunCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // Check if the flag property is true (meaning the function is already running)
            if (updatingFlag.GetPropertyValue())
                return;

            // Set the property flag to true to indicate we are running
            updatingFlag.SetPropertyValue(true);

            try
            {
                // Run the passed in action
                await action();
            }
            finally
            {
                // Set the property flag back to false now it's finished
                updatingFlag.SetPropertyValue(false);
            }
        }

        /// <summary>
        /// Executa um simples método que necessita de conexão com banco de dados
        /// Se a flag estiver como true (indicando que está sendo executado o metodo) então ele não executa mais uma outra vez.
        /// Se a flag estiver como false (indicando que não está sendo executado) então ele começa a executar o metodo.
        /// Quando terminar a execução, a flag é setada como false
        /// </summary>
        /// <param name="updatingFlag">A flag na qual indicará se o metodo está sendo executado ou não</param>
        /// <param name="action">O metodo passado que será executado caso a flag estiver como false</param>
        /// <returns></returns>
        protected async Task RunSimpleDBCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            var result = false;
            // Testa para ver se há conexão com o banco de dados
            await Task.Run(() => result = Connection.TestStaticConnection());
            if (!result)
                return;

            // Check if the flag property is true (meaning the function is already running)
            if (updatingFlag.GetPropertyValue())
                return;

            // Set the property flag to true to indicate we are running
            updatingFlag.SetPropertyValue(true);
            
            try
            {
                // Run the passed in action
                await action();
            }
            finally
            {
                // Set the property flag back to false now it's finished
                updatingFlag.SetPropertyValue(false);
            }
            
        }

        #endregion
    }
}
