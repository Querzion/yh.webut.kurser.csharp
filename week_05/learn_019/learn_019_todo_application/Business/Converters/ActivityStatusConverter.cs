using System.Globalization;
using Avalonia.Data.Converters;

namespace Business.Converters;

public class ActivityStatusConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isCompleted)
        {
            return isCompleted ? "completed" : "ongoing";
        }
        
        return "unknown";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}