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
using SQLite.Net.Platform.WinRT;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Elbow_Grease
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WorkOutPage : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public WorkOutPage(string username)
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLitePlatformWinRT(), path);
            double bmii = 0,bmr=0;


            var query = conn.Table<userdata2>();
            string height = "";
            string name = "";
            string weight = "";
            string waist = "";
            string bust = "";
            string hip = "";
            string neck = "";
            string age = "";
            string pas = "";


            foreach (var message in query)
            {
                if (message.Name1 == username)
                {
                    name = name + " " + message.Name1;
                    age = age + " " + message.Age1;
                    height = height + " " + message.Height1;
                    weight = weight + " " + message.Weight1;
                    waist = waist + " " + message.Waist1;
                    hip = hip + " " + message.Hip1;
                    neck = neck + " " + message.Neck1;
                    bust = bust + " " + message.Bust1;
                    pas = pas + " " + message.Password1;
                    bmii = message.Weight1 / (message.Height1 * message.Height1);
                    int ag = int.Parse(message.Age1);
                    if (message.Gender1 == "Male")
                    {
                        bmr = 66 + (13.7 * message.Weight1) + (5 * message.Height1) - (6.8 * ag);
                    }
                    if(message.Gender1=="Female")
                    {
                        bmr = 655 + (4.35 * message.Weight1) + (4.7 * message.Height1) - (4.7 * ag);
                    }
                }
                
                ak.Text = "UserName:: " + name + "\nHeight " + height+" Meters" + "\nAge: " + age + "\nWeight " + weight + "KG" + "\nWaist: " + waist + " Meters"
                    + "\nBUst " + bust + "Meters" + "\nHip: " + hip + " Meters" + "\nNeck: " + neck + " Meters" + "\nBMI: " + bmii;
                bk.Text = "UserName:: " + name + "\nHeight " + height + " Meters" + "\nAge: " + age + "\nWeight " + weight + "\nWaist: " + waist + " Meters"
                   + "\nBUst " + bust + " Meters" + "\nHip: " + hip + " Meters" + "\nNeck: " + neck +  " Meters" + "\nBMR: " + bmr;


            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new UserChoices();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new SignupPage();
        }
    }
        
   

       
    }

