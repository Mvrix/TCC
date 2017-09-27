using System;
using System.Globalization;

namespace TCC_Hidracom
{
    public class IconTypeToIconConverter : BaseValueConverter<IconTypeToIconConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((IconType)value)
            {
                case IconType.File:
                    return "File";

                case IconType.FileImage:
                    return "FileImage";

                case IconType.Settings:
                    return "Settings";

                case IconType.CalendarText:
                    return "CalendarText";

                case IconType.AccountPlus:
                    return "AccountPlus"; ;

                case IconType.AccountSearch:
                    return "AccountSearch";

                case IconType.Home:
                    return "Home";

                case IconType.AccountCircle:
                    return "AccountCircle";

                case IconType.Clipboard:
                    return "Clipboard";

                case IconType.ClipboardAccount:
                    return "ClipboardAccount";

                case IconType.ClipboardOutline:
                    return "ClipboardOutline";

                case IconType.ClipboardCheck:
                    return "ClipboardCheck";

                case IconType.ClipboardText:
                    return "ClipboardText";

                case IconType.ClipboardAlert:
                    return "ClipboardAlert";

                case IconType.Phone:
                    return "Phone";

                case IconType.CalendarClock:
                    return "CalendarClock";

                default:
                    return "Bug";
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
