using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//videorentproject@gmail.com
//moviesOscar100%
namespace MailApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainFrame { get; set; }
        public static bool LoggedIn { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MainFrame = mainFrame;
            this.Closed += new EventHandler(MainWindow_Closed);
            // Add this on application startup, remember to change the path
            //Debugging ImapX          
            System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(
                @"C:\Users\TeoDaily\Desktop\test.txt"));
            System.Diagnostics.Debug.AutoFlush = true;
            // Chance are, its not logged in.
            MainFrame.Content = new LoginPage();

            // Initialize the Imap
            ImapService.Initialize();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            if (LoggedIn)
            {             
                mainFrame.Navigate(new HomePage());
                panelError.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                // Problem
                panelError.Visibility = System.Windows.Visibility.Visible;
                errorText.Text = "You're not logged in!";//"There was a problem logging you in to Google Mail.";
            }         
        }

        private void btnInbox_Click(object sender, RoutedEventArgs e)
        {
            if (LoggedIn)
            {
                mainFrame.Navigate(new HomePage());
                panelError.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                // Problem
                panelError.Visibility = System.Windows.Visibility.Visible;
                errorText.Text = "You're not logged in!";//"There was a problem logging you in to Google Mail.";
            }
        }

        private void btnSent_Click(object sender, RoutedEventArgs e)
        {
            if (LoggedIn)
            {
                mainFrame.Navigate(new HomePage());
                panelError.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                // Problem
                panelError.Visibility = System.Windows.Visibility.Visible;
                errorText.Text = "You're not logged in!";//"There was a problem logging you in to Google Mail.";
            }
        }

        void MainWindow_Closed(object sender, EventArgs e)
        {
            ImapService.Logout();
        }
        //    public MainWindow()
        //    {
        //        InitializeComponent();
        //    }

        //private void btnNew_Click(object sender, RoutedEventArgs e)
        //{
        //    gridInbox.Visibility = System.Windows.Visibility.Hidden;
        //    gridSent.Visibility = System.Windows.Visibility.Hidden;
        //    gridNew.Visibility = System.Windows.Visibility.Visible;
        //}

        //private void btnInbox_Click(object sender, RoutedEventArgs e)
        //{
        //    gridNew.Visibility = System.Windows.Visibility.Hidden;
        //    gridSent.Visibility = System.Windows.Visibility.Hidden;
        //    gridInbox.Visibility = System.Windows.Visibility.Visible;
        //}

        //private void btnSent_Click(object sender, RoutedEventArgs e)
        //{
        //    gridNew.Visibility = System.Windows.Visibility.Hidden;
        //    gridInbox.Visibility = System.Windows.Visibility.Hidden;
        //    gridSent.Visibility = System.Windows.Visibility.Visible;
        //}
    }
}
