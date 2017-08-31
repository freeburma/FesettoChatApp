﻿
using System.Windows;

namespace FacettoChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

         
            /// Linking with WindowViewModel <see cref="WindowViewModel.cs">
            this.DataContext = new WindowViewModel(this); 
        }
    }
}
