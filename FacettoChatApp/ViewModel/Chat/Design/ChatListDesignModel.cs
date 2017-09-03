
using System.Collections.Generic;

namespace FacettoChatApp
{
    /// <summary>
    /// Design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instanc eof the design model. 
        /// </summary>
        // public static ChatListItemDesignModel Instance { get { return new ChatListItemDesignModel();  } } // Same as below
        public static ChatListDesignModel Instance => new ChatListDesignModel(); 

        #endregion

        #region Constructor 

        /// <summary>
        /// Default contructor 
        /// </summary>
        public ChatListDesignModel()
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
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "This chat app is awesome! I bet it will be fast too.",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true,
                },
                new ChatListItemViewModel
                {
                    Name = "Jesse",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icons.",
                    ProfilePictureRGB = "f34503"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405", 
                    IsSelected = true,

                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, ogt 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
            }; 
        }// end constructor()

        #endregion


    }// end class
}
