using System.Windows;
using Cooking_App.WebPages;

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
            mainFrame.Content = new HomePage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new MyFrdge();
        }
    }
}