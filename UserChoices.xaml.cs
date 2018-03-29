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


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Elbow_Grease
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserChoices : Page
    {
        int a = 0;

        public UserChoices()
        {
            this.InitializeComponent();
        }

        private void loseweight_Click(object sender, RoutedEventArgs e)
        {
            a = 1;
        }

        private void pack_Click(object sender, RoutedEventArgs e)
        {
            a = 2;
        }

        private void chest_Click(object sender, RoutedEventArgs e)
        {
            a = 3;
        }

        private void colar_Click(object sender, RoutedEventArgs e)
        {
            a = 4;
        }

        private void bicheps_Click(object sender, RoutedEventArgs e)
        {
            a = 5;
        }

        private void backcuts_Click(object sender, RoutedEventArgs e)
        {
            a = 6;
        }

        private void buts_Click(object sender, RoutedEventArgs e)
        {
            a = 7;
        }

        private void tighs_Click(object sender, RoutedEventArgs e)
        {
            a = 8;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {

            string parameters = new UserChoices().ToString();

            if (a == 1)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 2)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 3)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 4)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 5)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 6)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 7)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
            if (a == 8)
            {
                parameters = a.ToString();
                Window.Current.Content = new Videos(parameters);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new WorkOutPage(Name);
        }
    }
}
