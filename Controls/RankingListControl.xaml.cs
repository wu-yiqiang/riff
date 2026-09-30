using riff.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// RankingListControl.xaml 的交互逻辑
    /// </summary>
    public partial class RankingListControl : UserControl
    {
        public static readonly DependencyProperty labelProperty =
          DependencyProperty.Register(
              "Label",
              typeof(string),
              typeof(RankingListControl),
              new PropertyMetadata("新歌榜")
          );
        public static readonly DependencyProperty itemsSourceProperty =
         DependencyProperty.Register(
             "ItemsSource",
             typeof(ObservableCollection<AlbumModel>),
             typeof(RankingListControl),
             new PropertyMetadata(null)
         );
        public string Label
        {
            get { return (string)GetValue(labelProperty); }
            set { SetValue(labelProperty, value); }
        }
        public ObservableCollection<AlbumModel> ItemsSource
        {
            get { return (ObservableCollection<AlbumModel>)GetValue(itemsSourceProperty); }
            set { SetValue(itemsSourceProperty, value); }
        }
        public RankingListControl()
        {
            InitializeComponent();
           
        }
    }
}
