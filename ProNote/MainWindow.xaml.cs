using Fluent;
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

namespace ProNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            AboutWindow about = new AboutWindow();
            about.Show();
            about.Activate();
        }

        private void showinsiderinfo(object sender, RoutedEventArgs e)
        {

        }

        private void Open(object sender, RoutedEventArgs e)
        {

        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void update(object sender, RoutedEventArgs e)
        {

        }
    }
}