using System.Globalization;

namespace MauiGmailClone.Converters
{
    /// <summary>
    /// Converts avatar image name to image
    /// </summary>
    public class AvatarTypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var file = $"avatar_sender_{((string)value).ToLower()}.png";
            return ImageSource.FromFile(file);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
