using MaterialDesignThemes.Wpf;
using System;
using System.Globalization;

namespace TCC_Hidracom
{
    /// <summary>
    /// Converte o <see cref="CurrentQueue"/> para uma MessageQueue.
    /// </summary>
    public class ApplicationQueueValueConverter : BaseValueConverter<ApplicationQueueValueConverter>
    {
        public override object Convert(object value, Type targetType = null, object parameter = null, CultureInfo culture = null)
        {
            var queue = new SnackbarMessageQueue();
            queue.Enqueue((string)value);
            return queue;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}