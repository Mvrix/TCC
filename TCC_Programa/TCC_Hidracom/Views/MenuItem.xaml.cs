using System.Windows.Controls;
using System.Windows.Media;

namespace TCC_Hidracom
{
    /// <summary>
    /// Interaction logic for MenuItem.xaml
    /// </summary>
    public partial class MenuItem : UserControl
    {
        public MenuItem(string text, string icon)
        {
            InitializeComponent();
            LabelText.Text = text;
            VisualIcon.Visual = (Visual)this.TryFindResource(icon) ?? (Visual)this.TryFindResource("appbar_bug");
        }
    }
}
