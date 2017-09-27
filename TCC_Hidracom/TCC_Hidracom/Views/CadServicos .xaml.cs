using System.Windows;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for CadCliente.xaml
    /// </summary>
    public partial class CadServicos : Window
    {
        public CadServicos()
        {
            InitializeComponent();

            this.DataContext = new CadServicoViewModel()
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
