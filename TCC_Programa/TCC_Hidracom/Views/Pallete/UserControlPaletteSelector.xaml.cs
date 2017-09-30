using System.Windows.Controls;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for PaletteSelector.xaml
    /// </summary>
    public partial class UserControlPaletteSelector : UserControl
    {
        public UserControlPaletteSelector()
        {
            InitializeComponent();
            DataContext = new PaletteSelectorViewModel();
        }
    }
}
