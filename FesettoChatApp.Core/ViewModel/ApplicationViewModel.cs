using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FasettoChatApp.Core
{
    /// <summary>
    /// The application stage as view model.
    /// </summary>
    public class ApplicationViewModel
    {
        /// <summary>
        /// The curent page of the application <seealso cref="ApplicationPage"/>
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;


    }// end class
}
