using System.Windows;
using System.Windows.Controls;

namespace Cooking_App.WebPages
{
    public partial class MyFrdge : Page
    {
        public MyFrdge()
        {
            InitializeComponent();
            viewEntries.Items.Add("New Item1");
            viewEntries.Items.Add("New Item2");
            viewEntries.Items.Add("New Item3");
            viewEntries.Items.Add("New Item4");
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            viewEntries.Items.Add(AddEntryTxt.Text);
            AddEntryTxt.Clear();

        }

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            viewEntries.Items.Remove(AddEntryTxt.Text);
        }

        private void ChangeItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearOut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
