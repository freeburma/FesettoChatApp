﻿using System;
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
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        /// <summary>
        /// True if the side menu should be show.
        /// </summary>
        public bool SideMenuVisible { get; set; } = false; 




    }// end class
}
