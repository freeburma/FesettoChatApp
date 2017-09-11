
using System;
using System.Diagnostics;
using System.Globalization;
using Fasetto.Word.Core;

namespace Fasetto.Word
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/Page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page 
            switch ((ApplicationPage) value)
            {
                case ApplicationPage.Login:
                    return new LoginPage ();         // Pointing to the Login Page

                case ApplicationPage.Register:
                    return new RegisterPage();         // Pointing to the Register Page

                case ApplicationPage.Chat:
                    return new ChatPage ();         // Pointing to the Chat Page

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
