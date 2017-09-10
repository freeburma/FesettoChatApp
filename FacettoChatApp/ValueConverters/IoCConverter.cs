using Ninject;
using System.Globalization;
using System;
using System.Diagnostics;
using FasettoChatApp.Core;

namespace FasettoChatApp
{
    /// <summary>
    /// Converts a String name to a service  pulled from the IoC container
    /// </summary>
    public class IoCConverter : BaseValueConverter<IoCConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page 
            switch ((string)parameter)
            {
                // nameof(ApplicationViewModel) : is getting the FileName.cs
                case nameof(ApplicationViewModel):
                    return IoC.Get<ApplicationViewModel>();         // Pointing to the Login Page

                default:
                    Debugger.Break();               // Stopping the debugging
                    return null; 
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


    }// end class 
}
