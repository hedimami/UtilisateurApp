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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AppUser.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Inscription : Page
    {
        public Inscription()
        {
            this.InitializeComponent();
        }

        private void txtnom_GotFocus(object sender, RoutedEventArgs e)
        {
            txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void txtnom_LostFocus(object sender, RoutedEventArgs e)
        {
            bool test = txtnom.Text.All(char.IsLetter);
            if (txtnom.Text == "" || test == false)
            {
                txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                txtnom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
        }

        private void txtprenom_LostFocus(object sender, RoutedEventArgs e)
        {
            bool test = txtprenom.Text.All(char.IsLetter);
            if (txtprenom.Text == "" || test == false)
            {
                txtprenom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                txtprenom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
        }

        private void txtprenom_GotFocus(object sender, RoutedEventArgs e)
        {
            txtprenom.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void txttel_GotFocus(object sender, RoutedEventArgs e)
        {
            txttel.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void txttel_LostFocus(object sender, RoutedEventArgs e)
        {
            bool test = txttel.Text.All(char.IsNumber);
            if (txttel.Text.Length != 8 || test == false)
            {
                txttel.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                txttel.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
        }

        private void txtemail_LostFocus(object sender, RoutedEventArgs e)
        {

            bool test = true;
            int count = txtemail.Text.Split('.').Length - 1;
            if (count == 2)
            {
                int firstpos = txtemail.Text.IndexOf(".");
                int lastpos = txtemail.Text.LastIndexOf(".");
                int atpos = txtemail.Text.IndexOf("@");
                if (firstpos < atpos && atpos < lastpos)
                {
                    test = true;
                }
                else
                {
                    test = false;
                }

            }
            if (txtemail.Text.Contains("@") == false || txtemail.Text.Contains(".") == false || test == false)
            {
                txtemail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                txtemail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
        }

        private void txtemail_GotFocus(object sender, RoutedEventArgs e)
        {
            txtemail.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void txtpwc_GotFocus(object sender, RoutedEventArgs e)
        {
            txtpwc.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void txtpwc_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtpwc.Password != txtpw.Password)
            {
                txtpwc.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                txtpwc.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
        }

        private void txtdate_Tapped(object sender, TappedRoutedEventArgs e)
        {
            txtdate.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
        }

        private void txtpw_LostFocus(object sender, RoutedEventArgs e)
        {
            
            if (txtpw.Password.Length<=8 || txtpw.Password.Any(Char.IsNumber)==false || txtpw.Password.Any(Char.IsLetter) == false)
            {
                txtpw.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
            }
            else
            {
                txtpw.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Green);
            }
        }

        private void txtpw_GotFocus(object sender, RoutedEventArgs e)
        {
            txtpw.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
        }
    }
}
