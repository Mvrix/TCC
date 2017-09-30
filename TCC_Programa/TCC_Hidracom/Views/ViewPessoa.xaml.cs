using System.Windows;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for ViewPessoa.xaml
    /// </summary>
    public partial class ViewPessoa : Window
    {
        public ViewPessoa(int tipo)
        {
            InitializeComponent();

            this.DataContext = new ViewPessoaViewModel(tipo)
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
