using System;
using System.Globalization;
using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// A converter that takes in date and converts it to a user friendly time
    /// </summary>
    public class TimeToDisplayTimeConverter : BaseValueConverter<TimeToDisplayTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var time = (DateTimeOffset)value; 

            // IF it is today ... 
            if (time.Date == DateTimeOffset.UtcNow.Date)
            {
                // Return just time 
                return time.ToLocalTime().ToString("hh:mm tt"); 
            }

            return time.ToLocalTime().ToString("hh:mm, MMM yyyy");

                
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
