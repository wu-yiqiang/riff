using riff.ViewModels;
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

namespace riff.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
            MenuHome.IsSelected = true;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            var menus = new[] { MenuHome, MenuPlaylist, MenuSinger, MenuRank };
            foreach (var m in menus) m.IsSelected = ReferenceEquals(m, sender);
        }
    }
}