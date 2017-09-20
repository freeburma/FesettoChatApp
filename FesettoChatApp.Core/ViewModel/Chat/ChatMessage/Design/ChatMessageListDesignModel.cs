
using System;
using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Design-time data for a <see cref="ChatMessageListViewModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instanc eof the design model. 
        /// </summary>
        // public static ChatListItemDesignModel Instance { get { return new ChatListItemDesignModel();  } } // Same as below
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel(); 

        #endregion

        #region Constructor 

        /// <summary>
        /// Default contructor 
        /// </summary>
        public ChatMessageListDesignModel()
        {
            /*
                // The following code is as same as this. 

                Items = new List<ChatListItemViewModel> (); 
                var inst = new ChatListItemViewModel(); 
                inst.Name = "Luke";
                inst.Initials = "LM";
                inst. = "This chat app is awesome! I bet it will be fast too.";
                inst.ProfilePictureRGB = "3099c5";

                Items.add(inst); 
            */
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    SenderName = "Parnell",
                    Initials = "PL",
                    Message = "I'm about to wipe the old server. We need to update the old server to Windows 2016",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SendByMe = false,
                },
                new ChatMessageListItemViewModel
                {
                    SenderName = "Luke",
                    Initials = "LM",
                    Message = "Let me know when you manage to spin up the new 2016 server",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.3)),
                    SendByMe = true,
                },
                new ChatMessageListItemViewModel
                {
                    SenderName = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up. Go to 192.168.1.1. \r\nUser name admin, password is P8ssw0rd!",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SendByMe = false,
                },
            }; 
        }// end constructor()

        #endregion


    }// end class
}
