using Fasetto.Word.Core;
using System.Security;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<RegisterViewModel>, IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The secure password for this login page.
        ///   public SecureString SecurePassword {get;} = PasswordText.SecurePassword;= public SecureString SecurePassword => PasswordText.SecurePassword;
        /// </summary>

        public SecureString SecurePassword => PasswordText.SecurePassword; // PasswordText is an actual passwordbox


    }
}
