
using System;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Design-time data for a <see cref="ChatMessageListItemViewModel"/>
    /// </summary>
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instanc eof the design model. 
        /// </summary>
        // public static ChatMessageListItemDesignModel Instance { get { return new ChatMessageListItemDesignModel();  } } // Same as below
        public static ChatMessageListItemDesignModel Instance => new ChatMessageListItemDesignModel(); 

        #endregion

        #region Constructor 

        /// <summary>
        /// Default contructor 
        /// </summary>
        public ChatMessageListItemDesignModel()
        {
            Initials = "LM";
            SenderName = "Luke";
            Message = "Some design time visual text";
            ProfilePictureRGB = "3099c5";
            SendByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3));

        }// end constructor()

        #endregion


    }// end class
}
