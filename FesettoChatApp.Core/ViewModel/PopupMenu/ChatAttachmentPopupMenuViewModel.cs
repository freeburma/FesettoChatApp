
using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class ChatAttachmentPopupMenuViewModel : BasePopupMenuViewModel
    {
        #region Public Properties 


       
        #endregion

        #region Constructor 

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChatAttachmentPopupMenuViewModel()
        {
            Menu = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>(new[]
                {
                    new MenuItemViewModel { Text = "Attach a file ...", Type = MenuItemType.Header },
                    new MenuItemViewModel {Text = "From Computer", Icon = IconType.File},
                    new MenuItemViewModel {Text = "From Pictures", Icon = IconType.Picture},
                })
            };

            
        }

        #endregion

    }// end class BubbleCOntentViewModel
}
