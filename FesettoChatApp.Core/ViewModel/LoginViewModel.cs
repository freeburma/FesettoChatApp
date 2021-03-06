﻿using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties 

        /// <summary>
        /// Email of the users
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running - which will be waiting for Async Task.
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion


        #region Commands 

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        public LoginViewModel()
        {
            /// Create the commands <see cref="RelayCommand"/> 
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync ());


        }// end LoginViewModel()


        #endregion

        #region Tasks 

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter"> The <see cref="SecureString"/> passed in form the view for the user's password</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
          
            await RunCommandAsync(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                // Go to chat page 
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Chat); 

                // var email = this.Email;

                // Important: Never store unsecure password in variable like this 
                // var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });



            // LoginIsRunning = false;

        }// end Login()

        /// <summary>
        /// Takes the user to the register page. 
        /// </summary>
        public async Task RegisterAsync()
        {
           
            IoC.Get<ApplicationViewModel>().GoToPage (ApplicationPage.Register); 

            await Task.Delay(1); 

        }// end Login()

        #endregion
    }
}
