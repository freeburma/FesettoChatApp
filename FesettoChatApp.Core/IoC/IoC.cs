using Ninject;
using System;

namespace FasettoChatApp.Core
{

    /// <summary>
    /// IoC container for our application
    /// </summary>
    public static class IoC
    {
        #region Public Properties 
        /// <summary>
        /// The kernel for our IoC container. 
        /// Kernel is basically where you get and bind all of your inf in the 
        /// whole of an inject. 
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        #endregion
        
        #region Construction

        /// <summary>
        /// Sets up the IoC container, binds all inf required and is ready for use.
        /// Note: Must be called as soon as your application starts up to ensure all 
        ///       services can be found.
        /// </summary>
        public static void Setup ()
        {
            // Bind all required view models 
            BindViewModels(); 
        }// end Setup()


        /// <summary>
        /// Binds all singleton view models.
        /// </summary>
        private static void BindViewModels()
        {
            // Bind to a single instance of Application view model
            // Kernel.Bind<ApplicationViewModel>().ToSelf().InSingletonScope(); // Same as below 
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel()); 

        }// end BindViewModels

        #endregion

        #region Helper

        /// <summary>
        /// Get's a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T"> The type to get </typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

        #endregion

    }// end class
}
