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
using System.Diagnostics;
using Windows.System;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Elbow_Grease
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactusPage : Page
    {
        int a = 0;
        public ContactusPage()
        {
            this.InitializeComponent();
        }

        
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new MainPage();
        }

        private void myimage_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            if (a % 2 == 0)
            {
                myimag.Width =  200;
                myimag.Height = 160;
                                
            }
            if(a % 2 != 0)
            {
                myimag.Width  = 278;
                myimag.Height = 231;
            }
        }
    }
}
