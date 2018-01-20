﻿using System.Windows;
using SimpleMathQuiz.Core.ViewModels;

namespace SimpleMathQuiz.Wpf.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new GameViewModel();
        }
    }
}
