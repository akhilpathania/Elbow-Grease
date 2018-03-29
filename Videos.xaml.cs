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
using System.Threading.Tasks;





// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Elbow_Grease
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Videos : Page
    {
        int b = 0, d = 0;
        string videoID = "";
        public Videos(string a)
        {
            
            this.InitializeComponent();
           


             b = Convert.ToInt32(a);
            if(b==20)
            {
                button.Content = "LOGOUT";
                videoID = "user/sixpackshortcuts";
                d = 1;
            }

           if(b == 1)
            {
                videoID = "watch?v=4uQtPyWkXcc";
            }
           if(b == 2)
            {
                videoID = "watch?v=cfY_4m3RVRc";
            }
            if (b == 3)
            {
                videoID = "watch?v=hb-ESKUEovw";
            }
            if (b == 4)
            {
                videoID = "watch?v=voVahaOGp-4";
            }
            if (b == 5)
            {
                videoID = "watch?v=mwK7bJevQIY";
            }
            if (b == 6)
            {
                videoID = "watch?v=a_jTAJKpT2w";
            }
            if (b == 7)
            {
                videoID = "watch?v=sOt300BhBiA";
            }
            if (b == 8)
            {
                videoID = "watch?v=abnaNJUNNK4";
            }

            string html = @"<iframe width=""1102"" height=""500"" src=""http://www.youtube.com/" + videoID + @"?rel=0"" frameborder=""0"" allowfullscreen></iframe>";

            this.webView.NavigateToString(html);
      
        }
          
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (d == 1)
            {
                Window.Current.Content = new SignupPage();
            }
            else
            {
                Window.Current.Content = new UserChoices();

            }

         }

        private void food_Click(object sender, RoutedEventArgs e)
        {
            if (b == 1)
            {
                videoID = "watch?v=8IYeD-hNePo";
            }
            if (b == 2)
            {
                videoID = "watch?v=2SZ3B3Tqvh4";
            }
            if (b == 3)
            {
                videoID = "watch?v=ZPQLe2dn1iM";
            }
            if (b == 4)
            {
                videoID = "watch?v=C1s_2au4qcM";
            }
            if (b == 5)
            {
                videoID = "watch?v=C1s_2au4qcM";
            }
            if (b == 6)
            {
                videoID = "watch?v=C1s_2au4qcM";
            }
            if (b == 7)
            {
                videoID = "watch?v=C_I3kCRzpNw";
            }
            if (b == 8)
            {
                videoID = "watch?v=vHi2VJm6jG8";
            }

            string html = @"<iframe width=""1102"" height=""500"" src=""http://www.youtube.com/" + videoID + @"?rel=0"" frameborder=""0"" allowfullscreen></iframe>";

            this.webView.NavigateToString(html);
        }

       

        private void dont_Click(object sender, RoutedEventArgs e)
        {
            if (b == 1)
            {
                videoID = "watch?v=1kvrYtz9EJM";
            }
            if (b == 2)
            {
                videoID = "watch?v=kghVlbG3khs";
            }
            if (b == 3)
            {
                videoID = "watch?v=O6Y3WDY1tUo";
            }
            if (b == 4)
            {
                videoID = "watch?v=Sw3r2lytys8";
            }
            if (b == 5)
            {
                videoID = "watch?v=P6sN5XW-QuU";
            }
            if (b == 6)
            {
                videoID = "watch?v=Kd6iUdmbGOg";
            }
            if (b == 7)
            {
                videoID = "watch?v=hWV8Nk9-qm0";
            }
            if (b == 8)
            {
                videoID = "watch?v=2Ew0bdJMZvA";
            }

            string html = @"<iframe width=""1102"" height=""500"" src=""http://www.youtube.com/" + videoID + @"?rel=0"" frameborder=""0"" allowfullscreen></iframe>";

            this.webView.NavigateToString(html);
        }

        private void question_Click(object sender, RoutedEventArgs e)
        {

            videoID = "user/sixpackshortcuts";
            string html = @"<iframe width=""1102"" height=""500"" src=""http://www.youtube.com/" + videoID + @"?rel=0"" frameborder=""0"" allowfullscreen></iframe>";

            this.webView.NavigateToString(html);

            Window.Current.Content = new AskQuestion();
        }

        
    }
}
