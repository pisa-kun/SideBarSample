﻿using Prism.Commands;
using System.Windows;
using System.Windows.Controls;

namespace sample
{
    /// <summary>
    /// SideBarControl.xaml の相互作用ロジック
    /// </summary>
    public partial class SideBarControl : UserControl
    {
        public static readonly DependencyProperty ImageFileNameProperty =
            DependencyProperty.Register(nameof(ImageFileName), typeof(string), typeof(SideBarControl), new UIPropertyMetadata(string.Empty, new PropertyChangedCallback(OnPropertyChanged)));

        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register(nameof(ButtonText), typeof(string), typeof(SideBarControl), new UIPropertyMetadata(string.Empty, new PropertyChangedCallback(OnPropertyChanged)));

        public static readonly DependencyProperty ButtonCommandProperty =
            DependencyProperty.Register(nameof(ButtonCommand), typeof(DelegateCommand), typeof(SideBarControl), new UIPropertyMetadata(null, new PropertyChangedCallback(OnPropertyChanged)));

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(SideBarControl), new UIPropertyMetadata(false, new PropertyChangedCallback(OnPropertyChanged)));

        public string ImageFileName
        {
            get { return (string)GetValue(ImageFileNameProperty); }
            set { SetValue(ImageFileNameProperty, value); }
        }

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public bool IsSelected
        {
            get { return (bool)GetValue(IsSelectedProperty); }
            set
            {
                SetValue(IsSelectedProperty, value);
            }
        }

        public DelegateCommand ButtonCommand
        {
            get { return (DelegateCommand)GetValue(ButtonCommandProperty); }
            set { SetValue(ButtonCommandProperty, value); }
        }

        public SideBarControl()
        {
            InitializeComponent();
        }

        private static void OnPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        private void Sidebar_button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
