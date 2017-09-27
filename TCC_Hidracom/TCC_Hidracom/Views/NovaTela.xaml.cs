using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for CadCliente.xaml
    /// </summary>
    public partial class NovaTela : Window
    {
        public NovaTela(ICommand close)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Abre o menu novamente
            Application.Current.MainWindow.Visibility = Visibility.Visible;

            //Fecha a atual janela
            Close();
        }

        /// <summary>
        /// Log do programa
        /// </summary>
        private ILog _log { get; } = LogManager.GetLogger(typeof(CadCliente));
    }
}
