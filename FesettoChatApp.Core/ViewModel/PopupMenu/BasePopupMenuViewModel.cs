
namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class BasePopupMenuViewModel : BaseViewModel
    {
        #region Public Properties 

        /// <summary>
        /// The background color of the bubble in ARGB value.
        /// </summary>
        public string BubbleBackground { get; set; }
        
        /// <summary>
        /// The alignment of the bubble arrow.
        /// </summary>
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        #endregion

        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// </summary>
        public BasePopupMenuViewModel()
        {
            // Set default values 
            // TODO: Move colors into core and make use of it here
            BubbleBackground = "ffffffff";

            // Arrow alignment is left by default.
            ArrowAlignment = ElementHorizontalAlignment.Left; 
        }

        #endregion

    }// end class BubbleCOntentViewModel
}
