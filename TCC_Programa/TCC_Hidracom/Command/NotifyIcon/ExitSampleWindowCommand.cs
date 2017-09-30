using System.Windows;

namespace TCC_Hidracom
{
    /// <summary>
    /// Hides the main window.
    /// </summary>
    public class ExitSampleWindowCommand : CommandBase<ExitSampleWindowCommand>
    {
        public override void Execute(object parameter)
        {
            ((MainWindow)Application.Current.MainWindow).CloseNow = true;
            Application.Current.Shutdown();
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }
    }
}