using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The view model for a register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties 

        /// <summary>
        /// Email of the users
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the register command is running - which will be waiting for Async Task.
        /// </summary>
        public bool RegisterIsRunning { get; set; }

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

        public RegisterViewModel()
        {
            /// Create the commands <see cref="RelayCommand"/> 
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync (parameter));
            LoginCommand = new RelayCommand(async () => await LoginAsync ());


        }// end LoginViewModel()


        #endregion

        #region Tasks 

        /// <summary>
        /// Attempts to register a new user
        /// </summary>
        /// <param name="parameter"> The <see cref="SecureString"/> passed in form the view for the user's password</param>
        /// <returns></returns>
        public async Task RegisterAsync(object parameter)
        {
            await RunCommandAsync(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(5000);
                
            });



            // LoginIsRunning = false;

        }// end Login()

        /// <summary>
        /// Takes the user to the login page. 
        /// </summary>
        public async Task LoginAsync()
        {
           
            IoC.Get<ApplicationViewModel>().GoToPage (ApplicationPage.Login); 

            await Task.Delay(1); 

        }// end Login()

        #endregion
    }
}
