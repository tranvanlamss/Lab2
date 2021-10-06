using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2008M.Models;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2008M
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame _mainFrame;
        public MainPage()
        {
            this.InitializeComponent();
            _mainFrame = MainFrame;
        }
        private void HomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));
        }
        private void Contact(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Contact));
        }
        private void Customer(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));
        }
        private void Mail(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Mail));
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home", Icon = "\uE80F" };
            var item2 = new MenuItem() { Name = "Contact", MenuPage = "contact", Icon = "\uE946" };
            var item3 = new MenuItem() { Name = "Customer", MenuPage = "customer", Icon = "\uE80F" };
            var item4 = new MenuItem() { Name = "Mail", MenuPage = "mail", Icon = "\uE946" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);

        }
        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home), selectedItem); break;
                case "pi": MainFrame.Navigate(typeof(Pages.Contact)); break;
                case "customer": MainFrame.Navigate(typeof(Pages.Customer), selectedItem); break;
                case "mail": MainFrame.Navigate(typeof(Pages.Mail), selectedItem); break;
            }
        }


    }
}
