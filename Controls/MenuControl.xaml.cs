using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace riff.Controls
{
    public partial class MenuControl : UserControl
    {
        public static readonly DependencyProperty labelProperty =
           DependencyProperty.Register(
               "Label",
               typeof(string),
               typeof(MenuControl),
               new PropertyMetadata("首页")
           );
        public static readonly DependencyProperty iconProperty =
           DependencyProperty.Register(
               "Icon",
               typeof(string),
               typeof(MenuControl),
               new PropertyMetadata("&#xe6ac;")
           );
        public string Label
        {
            get { return (string)GetValue(labelProperty); }
            set { SetValue(labelProperty, value); }
        }
        public string Icon
        {
            get { return (string)GetValue(iconProperty); }
            set { SetValue(iconProperty, value); }
        }
        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(MenuControl),
                new PropertyMetadata(false));
        public bool IsSelected { get => (bool)GetValue(IsSelectedProperty); set => SetValue(IsSelectedProperty, value); }
        public event RoutedEventHandler Click;
        private void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IsSelected = true;
            Click?.Invoke(this, e);
        }
        public MenuControl()
        {
            InitializeComponent();
            this.DataContext = this;
            MouseLeftButtonUp += OnMouseLeftButtonUp;

        }
    }
}
