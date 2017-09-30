using System.Threading.Tasks;
using System.Windows.Controls;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for Cadastrado.xaml
    /// </summary>
    public partial class Cadastrado : UserControl
    {
        public Cadastrado(string batata)
        {
            InitializeComponent();
            txtTexto.Text = batata;
        }
    }
}
