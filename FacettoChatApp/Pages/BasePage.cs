using Fasetto.Word.Core;
using System;//
using System.Threading.Tasks;//
using System.Windows;//
using System.Windows.Controls;  //
using System.Windows.Media.Animation;//

// FacettoChatApp

namespace Fasetto.Word
{
    /// <summary>
    /// A base page for all pages to gain base functionality
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {

        #region Private Member 

        /// <summary>
        /// The view model associated with this page
        /// </summary>
        private VM mViewModel; 

        #endregion

        #region Public Properties 

        /// <summary>
        /// The animation the play when the page is first loaded.
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation the play when the page is first unloaded.
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation takes to complete.
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// The View Model associated with this page.
        /// </summary>
        public VM ViewModel
        {
            get => mViewModel; 
            set
            {
                // If nothing has changed, return and do nothing.
                if (mViewModel == value)
                    return;

                // Update the value.
                mViewModel = value;

                // Set the data context for this page.
                this.DataContext = mViewModel;  // Bind to the Email at the login page
            }
        }

        #endregion

        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BasePage()
        {
            
            // If we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            // Listen out for the page loading
            this.Loaded += BasePage_LoadedAsync;

            // Create a default view model
            this.ViewModel = new VM(); 
        }

        #endregion

        #region Animation Load/Unload

        /// <summary>
        /// Once the load is loaded, perform any required animation
        /// </summary>
        /// <param name="sender">  </param>
        /// <param name="e">   </param>
        private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
        {
            // Animate the page in 
            await AnimateInAsync(); 
        }

        /// <summary>
        /// Animates in this page.
        /// </summary>
        /// <returns></returns>
        public async Task AnimateInAsync()
        {
            // Make sure we have something to do 
            if (this.PageLoadAnimation == PageAnimation.None)
            {
                Console.WriteLine("Page Load Animation >>>> None ");
                return;
            }
                    

            switch (this.PageLoadAnimation)
            {                
                case PageAnimation.SlideAndFadeInFromRight:
                    // MessageBox.Show(">>> PageAnimation.SlideAndFadeInFromRight");

                    // Start the animation
                    await this.SlideAndFadeInFromRightAsync(this.SlideSeconds * 2); 

                    break;
               
            }

        }// end AnimateIn()

        /// <summary>
        /// Animate the page out 
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOutAsync ()
        {
            // Make sure we have something to do 
            if (this.PageUnloadAnimation == PageAnimation.None)
            {
                Console.WriteLine("Page Load Animation >>>> None ");
                return;
            }


            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:
                    // MessageBox.Show(">>> PageAnimation.SlideAndFadeInFromRight");

                    // Start the animation
                    await this.SlideAndFadeOutToLeftAsync(this.SlideSeconds);

                    break;

            }
        }// end AnimateOut ()

        #endregion

       

    }// end class 
}
