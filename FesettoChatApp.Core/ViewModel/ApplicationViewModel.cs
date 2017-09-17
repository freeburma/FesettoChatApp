using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The application stage as view model.
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The curent page of the application <seealso cref="ApplicationPage"/>
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;

        /// <summary>
        /// True if the side menu should be show.
        /// </summary>
        public bool SideMenuVisible { get; set; } = false; 

        /// <summary>
        /// Navigate to the specified page
        /// </summary>
        /// <param name="chat"> The page to go to </param>
        public void GoToPage (ApplicationPage page)
        {
            // Set th current page
            CurrentPage = page;

            // Show side menu or not 

            /*
                if the page is equal to ApplicationPage.Chat fires SideMenuVisible () 
             */
            SideMenuVisible = page == ApplicationPage.Chat; 
        }


    }// end class
}
