
namespace Fasetto.Word.Core
{
    /// <summary>
    /// Design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instanc eof the design model. 
        /// </summary>
        // public static ChatListItemDesignModel Instance { get { return new ChatListItemDesignModel();  } } // Same as below
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel(); 

        #endregion

        #region Constructor 

        /// <summary>
        /// Default contructor 
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "LM";
            Name = "Luke";
            Message = "This chat app is awesome! I bet it will be fast too.";
            ProfilePictureRGB = "3099c5"; 
        }// end constructor()

        #endregion


    }// end class
}
