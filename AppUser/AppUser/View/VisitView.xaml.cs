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
    public sealed partial class VisitView : Page
    {
        public VisitView()
        {
            this.InitializeComponent();
            txtdevise.Items.Add("Euro €");
            txtdevise.Items.Add("Dollar $");
            txtdevise.Items.Add("Pound £");
            txtage.Items.Add("moin 12ans");
            txtage.Items.Add(" 12-18 ans");
            txtage.Items.Add(" 18-30 ans");
            txtage.Items.Add(" plus 30ans");
            txtsexe.Items.Add("Homme");
            txtsexe.Items.Add("Femme");
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
