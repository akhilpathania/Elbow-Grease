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
    public sealed partial class NewUserDataPage : Page
    {
        string path,gend,pass,nam;
        int act = 0,unit=0;
        SQLite.Net.SQLiteConnection conn;
       
        
        /// <summary>
        /// For Taking Username and Password From SignupPage 
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// 

        public NewUserDataPage(string sname, string password)
        {
            
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<userdata2>();


            pass = password.ToString();
            nam = sname.ToString();
            name.Text = "Hello " + (sname).ToUpper() +" Password is: "+(pass) + " how you doing";
            
        }
        
        private void unitBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(unitBox.SelectedIndex ==0)
            {
                unit = 0;
            }
            if(unitBox.SelectedIndex==1)
            {
                unit = 1;
            }
                
        }

        private void activityBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (activityBox.SelectedIndex ==0)
            {
                act = 0;
            }
            if (activityBox.SelectedIndex == 1)
            {
                act = 1;
            }
            if (activityBox.SelectedIndex == 2)
            {
                act = 2;
            }
            if (activityBox.SelectedIndex == 3)
            {
                act = 3;
            }
            if (activityBox.SelectedIndex == 4)
            {
                act = 4;
            }
            if (activityBox.SelectedIndex == 5)
            {
                act = 5;
            }
        }

        private void male_Click(object sender, RoutedEventArgs e)
        {
            gend = "Male";
            
        }

        private void female_Click(object sender, RoutedEventArgs e)
        {
            gend = "Female";
            
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            double totheight=0, totneck=0, totwaist=0, tothip=0, totbust=0,totweight=0;
            double h1, n1, w1, hi1, b1;

            h1 = double.Parse(feetinput.Text);
            
            n1 = double.Parse(neckfeetinput.Text);
          
            w1 = double.Parse(waistfeetinput.Text);
           
            hi1 = double.Parse(hipfeetinput.Text);
       
            b1 = double.Parse(bustfeetinput.Text);
            
            totweight = double.Parse(poundinput.Text);

            if(unit == 0)
            {
                totheight = h1 * 0.3048;
                totneck = n1 * 0.3048;
                totwaist = w1 * 0.3048;
                tothip = hi1 * 0.3048;
                totbust = b1 * 0.3048;
                totweight = totweight * 0.453592;



            }
            if(unit ==1)
            {
                totheight = h1;
                totneck = n1;
                totwaist =w1;
                tothip = hi1;
                totbust = b1;
               
            }



            var s = conn.Insert(new userdata2()
            {

                Name1 = nam,
                Password1 = pass,
                Age1 = ageinput.Text,
                Gender1 = gend,
                Height1 = totheight,
                Weight1 = totweight,
                Activity1 = act,
                Neck1= totneck,
                Waist1 = totwaist,
                Hip1 = tothip,
                Bust1 = totbust,

            });


            Window.Current.Content = new SignupPage();

        }

        private void unitbutton_Click(object sender, RoutedEventArgs e)
        {
            if (unit== 1)
            {
                feetinput.PlaceholderText = "Meters";             
                feet.Text = "Meters";        
                poundinput.PlaceholderText = "Kilograms";
                pound.Text = "Kilograms";
                neckfeet.Text = "Meters";
                neckfeetinput.PlaceholderText = "Meters";
                waistfeet.Text = "Meters";
                waistfeetinput.PlaceholderText = "Meters";
                hipfeet.Text = "Meters";
                hipfeetinput.PlaceholderText = "Meters";
                bustfeet.Text = "Meters";
                bustfeetinput.PlaceholderText = "Meters";
     

            }
            if (unit== 0)
            {
                feetinput.PlaceholderText = "Feet";                
                feet.Text = "Feet";              
                poundinput.PlaceholderText = "Pounds";
                pound.Text = "Pounds";
                neckfeet.Text = "Feet";
                neckfeetinput.PlaceholderText = "Feet";             
                waistfeet.Text = "Feet";
                waistfeetinput.PlaceholderText = "Feet";                
                hipfeet.Text = "Feet";
                hipfeetinput.PlaceholderText = "Feet";            
                bustfeet.Text = "Feet";
                bustfeetinput.PlaceholderText = "Feet";           
            }
        }



        private void back_Click(object sender, RoutedEventArgs e)
        {
            Window.Current.Content = new SignupPage();
        }

        private void activitybutton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }

    public class userdata2
    {
        [Unique,NotNull,PrimaryKey]
        public string Name1 { get; set; }
        [NotNull]
        public string Password1 { get; set; }
        [NotNull]
        public string Age1 { get; set; }
        [NotNull]
        public string Gender1 { get; set; }
        [NotNull]
        public double Height1 { get; set; }
        [NotNull]
        public double Weight1 { get; set; }
        [NotNull]
        public int Activity1 { get; set; }
        [NotNull]
        public double Neck1 { get; set; }
        [NotNull]
        public double Waist1 { get; set; }
        [NotNull]
        public double Hip1 { get; set; }
        [NotNull]
        public double Bust1 { get; set; }
    }
}
