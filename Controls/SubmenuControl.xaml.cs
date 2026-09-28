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
    /// <summary>
    /// SubmenuControl.xaml 的交互逻辑
    /// </summary>
    public partial class SubmenuControl : UserControl
    {
        public static readonly DependencyProperty labelProperty =
           DependencyProperty.Register(
               "Label",
               typeof(string),
               typeof(SubmenuControl),
               new PropertyMetadata("首页")
           );
        public static readonly DependencyProperty iconProperty =
           DependencyProperty.Register(
               "Icon",
               typeof(string),
               typeof(SubmenuControl),
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
        public SubmenuControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
