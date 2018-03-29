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
using SQLite.Net.Attributes;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Elbow_Grease
{


    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignupPage : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public SignupPage()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<userdata2>();
        }
        int count = 0;
        private void signup_Click(object sender, RoutedEventArgs e)
        {
            count = count + 1;
            if (sUsername.Text == "" || sPassword.Password == "" || sPasswordc.Password == "")
            {
                String aaa = "Please Fill All Information";
                t1.Text = aaa;

            }
            else if (sPasswordc.Password != sPassword.Password)
            {
                String aaa = "Password Not Matched";
                t1.Text = aaa;

                
            }

            if (count % 2 == 0)
            {

                string parameters = new SignupPage().ToString();
                string para = new SignupPage().ToString();
                parameters = sUsername.Text;
                para = sPassword.Password;
                Window.Current.Content = new NewUserDataPage(parameters, para);

            }
            else
            {
                String aaa = "You Are Registered Press SignUp ";
                t1.Text = aaa;
            }
        }



        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new MainPage();
        }


        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<userdata2>();
            foreach (var message in query)
            {
                if (lUsername.Text == message.Name1 && lPassword.Password == message.Password1)
                {
                    String aaa = "You Are Logged In";
                    t1.Text = aaa;
                    string parameters = new SignupPage().ToString();
                    parameters = lUsername.Text;
                    Window.Current.Content = new WorkOutPage(parameters);

                }
                else
                {
                    String aaa = "Please Fill Correct Credentials";
                    t1.Text = aaa;

                }
            }
        }

        private void guest_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new Videos("20");
        }
    }

}