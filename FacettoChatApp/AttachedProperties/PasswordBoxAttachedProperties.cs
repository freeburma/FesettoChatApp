
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace FacettoChatApp
{

    /// <summary>
    /// The ButtonAttachedProperties attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the caller 
            var passwordBox = sender as PasswordBox;

            // Make sure it is a password box 
            if (passwordBox == null)
                return;

            // Remove any previous events 
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged; 

            // If the caller set MonitorPassword to true.... 
            if ((bool) e.NewValue)
            {
                // Set default vlaue 
                HasTextProperty.SetValue(passwordBox); 

                // start listen out for password changes 
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged; 
            }

        }

        /// <summary>
        /// Fired when the password box password value changes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Set teh attached HasText value
            HasTextProperty.SetValue((PasswordBox) sender);

        }

    }// end class ButtonAttachedProperties

    /// <summary>
    /// The HasText attached property for a <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {

        /// <summary>
        /// Sets the HashText property based on if the caller <see cref="PasswordBox"/> has any text
        /// </summary>
        /// <param name="sender"></param>
        public static void SetValue (DependencyObject sender)
        {

            /*
                Same as below code. 
                HasTextProperty.SetValue((PasswordBox) sender, passwordBox.SecurePassword.Length > 0);
                HasTextProperty.SetValue((PasswordBox)sender, ((PasswordBox)sender).SecurePassword.Length > 0);
             */

            
            HasTextProperty.SetValue((PasswordBox)sender, ((PasswordBox)sender).SecurePassword.Length > 0);
        }

    }// end class HasTextProperty

}
