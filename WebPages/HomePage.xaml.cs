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
            /*switch(pageName)
            {
                case "prof":
                    homeMainFrame.Navigate(new Uri("UserProfilePage.xaml", UriKind.Relative));
                    break;

                case "fridge":
                    homeMainFrame.Navigate(new Uri("MyFridge.xaml", UriKind.Relative));
                    break;

                case "fav":
                    homeMainFrame.Navigate(new Uri("MyFavourites.xaml", UriKind.Relative));
                    break;

                case "addRecipe":
                    homeMainFrame.Navigate(new Uri("AddRecipe.xaml", UriKind.Relative));
                    break;

                case "faqs":
                    homeMainFrame.Navigate(new Uri("FAQs.xaml", UriKind.Relative));
                    break;

                case "stngs":
                    homeMainFrame.Navigate(new Uri("Settings.xaml", UriKind.Relative));
                    break;

                case "abt":
                    homeMainFrame.Navigate(new Uri("AboutUs.xaml", UriKind.Relative));
                    break;

                case "revs":
                    homeMainFrame.Navigate(new Uri("Reviews.xaml", UriKind.Relative));
                    break;
            }*/
        }


    }
}
