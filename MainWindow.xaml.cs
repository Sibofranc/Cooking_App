using System.Windows;

namespace Cooking_App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new WebPages.HomePage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new WebPages.MyFrdge();
        }
    }
}