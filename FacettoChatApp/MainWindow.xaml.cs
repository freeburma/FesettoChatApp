
using FasettoChatApp.Core;
using System.Windows;

namespace FasettoChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationViewModel ApplicationViewModel => new ApplicationViewModel();

        public MainWindow()
        {
            InitializeComponent();

         
            /// Linking with WindowViewModel <see cref="WindowViewModel.cs">
            DataContext = new WindowViewModel(this); 
        }
    }
}
