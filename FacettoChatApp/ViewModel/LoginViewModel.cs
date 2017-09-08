using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FacettoChatApp
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
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync ());


        }// end LoginViewModel()


        #endregion

        #region Tasks 

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter"> The <see cref="SecureString"/> passed in form the view for the user's password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            /*
             // This is define inside the ExpressionHelpers.cs
            // This prevent the user clicked the Next button when it is waiting for Async Task to complete.
            if (LoginIsRunning)
                return;

            LoginIsRunning = true; 
            */

            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                var email = this.Email;

                // Important: Never store unsecure password in variable like this 
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });



            // LoginIsRunning = false;

        }// end Login()

        /// <summary>
        /// Takes the user to the register page. 
        /// </summary>
        public async Task RegisterAsync()
        {
            // TODO: Go to register page?
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Register; 

            await Task.Delay(1); 

        }// end Login()

        #endregion
    }
}
