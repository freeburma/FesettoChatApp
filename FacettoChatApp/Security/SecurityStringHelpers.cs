using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Runtime.InteropServices;

namespace FasettoChatApp
{
    /// <summary>
    /// Helpers for <see cref="SecureString"/> class 
    /// </summary>
    public static class SecurityStringHelpers
    {
        

        /// <summary>
        /// Unsecures a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="secureString"> the secure string</param>
        /// <returns></returns>
        public static string Unsecure (this SecureString secureString)
        {
            // Make sure we have a secure string.
            if (secureString == null)
                return string.Empty; 

            // Get a pointer for an unsecure string in memory
            var unmanagedString = IntPtr.Zero;

            try
            {
                // Unsecures the password
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);

                return Marshal.PtrToStringUni(unmanagedString); 
            }
            finally
            {

                // Clean up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString); 
            }
        }

    }// end class
}
