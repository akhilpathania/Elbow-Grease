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
    public sealed partial class AskQuestion : Page
    {
        public AskQuestion()
        {
            this.InitializeComponent();
        }

        private void askquestion_Click(object sender, RoutedEventArgs e)
        {
            string videoID = question.Text;


            string html = @"<iframe width=""1102"" height=""500"" src=""https://www.quora.com/" + videoID + @"?rel=0"" frameborder=""0"" allowfullscreen></iframe>";

            this.quora.NavigateToString(html);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new Videos("20");
        }
    }
}
