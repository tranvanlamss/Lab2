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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Customer : Page
    {
        private List<Customers> customers = new List<Customers>();
        
        public Customer()
        {
            this.InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputName.Text == "" || inputAge.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }
            else
            {
                
                var c = new Customers() { Name = inputName.Text, Age = inputAge.Text, Address = inputAddress.Text};
                customers.Add(c);
                PrintCustomers();
                inputName.Text = "";
                inputAge.Text = "";
                inputAddress.Text = "";
            }
        }

        private void PrintCustomers()
        {
            txtCustomer.Text = "";
            foreach (Customers c in customers)
            {
                txtCustomer.Text += c.Name + "--" + c.Age + "--" + c.Address;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.Home));
        }
    }
}
