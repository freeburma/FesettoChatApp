
using FasettoChatApp.Core;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace FasettoChatApp
{
    /// <summary>
    /// The view model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        #region Private Properties 

        // Properties 

        /// <summary>
        /// The window this view model controls 
        /// </summary>
        private Window mWindow;

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        private int mOuterMarginSize = 10; // Outer Margin 

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        private int mWindowRadius = 10;    // Window radius

        #endregion

        #region Public Properties 

        
        /// <summary>
        /// The last know dock position
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked; 

        /// <summary>
        /// The smallest window size
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 800;

        /// <summary>
        /// The largest window size
        /// </summary>
        public double WindowMaximumHeight { get; set; } = 500;

        /// <summary>
        /// True if the window should be borderless because it is docked or maximized.
        /// </summary>
        public bool Borderless => (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked); 

        /// <summary>
        /// The size of the resize border around the window, tracking finto account the outer margin
        /// public int ResizeBorder { get; set; } = 6; 
        /// </summary>
        public int ResizeBorder => Borderless ? 0 : 6; 

        /// <summary>
        /// The Padding Inner content of the main window 
        /// public Thickness InnerContentPadding { get { return new Thickness(ResizeBorder); } } // Comment for changes.
        /// </summary>
        public Thickness InnerContentPadding { get; set; } = new Thickness(0); 


        /// <summary>
        /// The size of the resize border around the window 
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OuterMarginSize); 

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            // When you maximize the the outer magin size = 0; 
            get => Borderless ? 0 : mOuterMarginSize;  
            set => mOuterMarginSize = value; 
        }

        /// <summary>
        /// The margin thickness around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness => new Thickness(OuterMarginSize);  

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            // When the full screen, don't want a radius
            get => Borderless ? 0 : mWindowRadius;
            set => mWindowRadius = value;
        }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius); 

        /// <summary>
        /// The height of the title bar / caption of the window 
        /// </summary>
        public int TitleHeight { get; set; } = 42;

        /// <summary>
        /// The height of the title bar / caption of the window 
        /// </summary>
        public GridLength TitleHeightGridLength => new GridLength(TitleHeight + ResizeBorder); 

        /// <summary>
        /// The curent page of the application <seealso cref="ApplicationPage"/>
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login; 

        #endregion


        #region Commands 

        /// <summary>
        /// The command to minize the window 
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to maximize the window 
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// The command to close the window 
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to show the system menu of the window 
        /// </summary>
        public ICommand MenuCommand { get; set; }

        #endregion

        #region Default Constructor

        /// <summary>
        /// Default Constructor
        /// Controling the window directly
        /// </summary>
        public WindowViewModel(Window window)
        {
            this.mWindow = window;

            //

            // Listen out foir the window resizing
            this.mWindow.StateChanged += (sender, e) =>
            {
                // Fire off events for all properties that are effected by a resize 
                WindowResized(); 
            };

            /// Create the commands <see cref="RelayCommand"/> 
            MinimizeCommand = new RelayCommand(() => this.mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => this.mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => this.mWindow.Close());

            // Drop down menu to close, minize, maximize 
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(this.mWindow, GetMousePositionCustom()));


            // Fix window resize issue 
            var resizer = new WindowResizer(this.mWindow);

            // Listen out for dock changes 
            resizer.WindowDockChanged += (dock) =>
            {
                // Store the last position 
                mDockPosition = dock;

                // Fire off resize events 
                WindowResized();
            };
        }

        #endregion

        #region Private Helpers 

        /// <summary>
        /// This work also 
        /// </summary>
        /// <param name="pt"></param>
        /// <returns></returns>



        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        internal static extern bool GetCursorPos(ref Win32Point pt); 

        [StructLayout (LayoutKind.Sequential)]

        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y; 
        }; 

        /// <summary>
        /// Get the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private static Point GetMousePosition ()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);

            return new Point(w32Mouse.X, w32Mouse.Y); 
        }

        /// <summary>
        /// The current mouse position 
        /// Has a bug when you maximize
        /// </summary>
        /// <returns></returns>
        private Point GetMousePositionCustom()
        {
            // Position of the mouse relative to the window 
            var position = Mouse.GetPosition(this.mWindow); 
            

            // Add the window position so its a "ToScreen"
            return new Point(position.X + this.mWindow.Left, position.Y + this.mWindow.Top);
        }


        /// <summary>
        /// IF the window resizes to a special position (docked or maximized)
        /// This will update all required propert change events to set the borders and radius values.
        /// </summary>
        private void WindowResized ()
        {
            /// Fire off events for all properties that are effect by a resize <see cref="BaseViewModel.OnPropertyChanged(string)"/>
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));

        }// end WindowResized()


        #endregion 


    }
}
