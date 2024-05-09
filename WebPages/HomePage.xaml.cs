using Cooking_App.View.UserControls;
using System.Windows.Controls;

namespace Cooking_App.WebPages
{
    public partial class HomePage : Page
    {
        private MenuBarView menuBarView; 

        public HomePage()
        {
            InitializeComponent();

            menuBarView = new MenuBarView();
            Content = menuBarView;
            menuBarView.ButtonClicked += MenuBarView_ButtonClicked;
        }

        private void MenuBarView_ButtonClicked(object sender, string pageName)
        {
            switch(pageName)
            {
                case "prof":
                    homeMainFrame.Content = new UserProfilePage();
                    break;

                case "fridge":
                    homeMainFrame.Content = new MyFrdge();
                    break;

                case "fav":
                    homeMainFrame.Content = new MyFavourites();
                    break;

                case "addRecipe":
                    homeMainFrame.Content = new AddRecipe();
                    break;

                case "faqs":
                    homeMainFrame.Content = new FAQs();
                    break;

                case "stngs":
                    homeMainFrame.Content = new Settings();
                    break;

                case "abt":
                    homeMainFrame.Content = new UserProfilePage();
                    break;

                case "revs":
                    homeMainFrame.Navigate(new Uri("Reviews.xaml", UriKind.Relative));
                    break;
            }
        }


    }
}
