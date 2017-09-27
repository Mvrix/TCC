using System.Windows;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for CadCliente.xaml
    /// </summary>
    public partial class CadCliente : Window
    {
        public CadCliente(int tipo)
        {
            InitializeComponent();

            this.DataContext = new CadClienteViewModel(tipo)
            {
                BackCommand = new RelayCommand(() => 
                {
                    Application.Current.MainWindow.Visibility = Visibility.Visible;
                    Close();
                })
            };
        }
    }
}
