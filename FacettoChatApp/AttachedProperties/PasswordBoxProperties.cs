
using System;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /*
        This class is not used in the code. 
        This is the example how to make a custom event. See the Generic model type 
     */
     /// <summary>
     /// Generic Class for this class <see cref="BaseAttachedProperty{Parent, Property}"/>
     /// </summary>
    public class PasswordBoxProperties
    {
        public static readonly DependencyProperty MonitorPasswordProperty = 
            DependencyProperty.RegisterAttached("MonitorPassword", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false, OnMonitorPasswordChanged));

        private static void OnMonitorPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = (d as PasswordBox);

            if (passwordBox == null)
                return;

            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            if ((bool) e.NewValue)
            {
                SetHashText(passwordBox); 
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged; 
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SetHashText((PasswordBox)sender); 
        }

        // Creating the Getter & Setter 
        public static void SetMonitorPassword(PasswordBox element, bool value)
        {
            element.SetValue(MonitorPasswordProperty, value);
        }

        public static bool GetMonitorPassword(PasswordBox element)
        {
            return (bool)element.GetValue(MonitorPasswordProperty);
        }

        // ===================================================================================================
        public static readonly DependencyProperty HasTextProperty = 
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false));

        // Creating the Getter & Setter 
        private static void SetHashText (PasswordBox element)
        {
            element.SetValue(HasTextProperty, element.SecurePassword.Length > 0); 
        }

        public static bool GetHashText (PasswordBox element)
        {
            return (bool)element.GetValue(HasTextProperty);
        }

    }// end class
}
