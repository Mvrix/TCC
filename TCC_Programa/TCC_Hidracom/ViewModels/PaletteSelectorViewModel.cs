using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using MaterialDesignColors;
using TCC_Hidracom;

namespace TCC_Hidracom
{
    public class PaletteSelectorViewModel
    {
        public PaletteSelectorViewModel()
        {
            Swatches = new SwatchesProvider().Swatches;
        }

        public ICommand ToggleBaseCommand { get; } = new AnotherCommandImplementation(o => ApplyBase((bool)o));

        private static void ApplyBase(bool isDark)
        {
            try
            {
                new PaletteHelper().SetLightDark(isDark);
            }
            catch (Exception)
            {

            }
        }

        public IEnumerable<Swatch> Swatches { get; }

        public ICommand ApplyPrimaryCommand { get; } = new AnotherCommandImplementation(o => ApplyPrimary((Swatch)o));

        private static void ApplyPrimary(Swatch swatch)
        {
            try
            {
                new PaletteHelper().ReplacePrimaryColor(swatch);
            }
            catch (Exception)
            {
            }
        }

        public ICommand ApplyAccentCommand { get; } = new AnotherCommandImplementation(o => ApplyAccent((Swatch)o));

        private static void ApplyAccent(Swatch swatch)
        {
            try
            {
                new PaletteHelper().ReplaceAccentColor(swatch);
            }
            catch (Exception)
            {
            }
        }
    }
}
