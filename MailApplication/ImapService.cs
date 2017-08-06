using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ImapX;
using ImapX.Collections;
using System.Windows;

namespace MailApplication
{
    class EmailFolder
    {
        public String Title { get; set; }
    }

    class ImapService
    {
        private static ImapClient client { get; set; }
        private static bool connection;
        public static void Initialize()
        {
            //https://stackoverflow.com/questions/43325058/cant-connect-to-gmail-with-imapx-using-c-sharp/43325908
            try
            {
                client = new ImapClient("imap.gmail.com", true);
                //var client2 = new ImapClient("imap.gmail.com", 993, true);
                client.IsDebug = true;
                if (!client.Connect())
                {
                    connection = client.IsConnected;
                    MessageBox.Show("Error connecting to the client.");
                    //throw new Exception("Error connecting to the client.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
       }


        public static bool Login(string user, string pass)
        {
            try
            {
                return client.Login(user, pass);
            }
            catch (Exception ex)      
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           
        }

        public static void Logout()
        {
            // Remove the login value from the client.
            if (client.IsAuthenticated) { client.Logout(); }

            // Clear the logged in value.
            MainWindow.LoggedIn = false;
        }

        public static List<EmailFolder> GetFolders()
        {
            var folders = new List<EmailFolder>();
            //client.Folders
            foreach (var folder in client.Folders)
            {
                if (folder.SubFolders.Count() > 0)
                {
                    foreach (var subfolder in folder.SubFolders)
                    {
                        folders.Add(new EmailFolder { Title = subfolder.Name });
                    }                     
                }
                else
                {
                    folders.Add(new EmailFolder { Title = folder.Name });
                }
             }          
                MessageBox.Show("no of folders " + folders.Count);

            // Before returning start the idling
            //client.Folders.Inbox.StartIdling(); // And continue to listen for more.

            //client.Folders.Inbox.OnNewMessagesArrived += Inbox_OnNewMessagesArrived;
            return folders;
        }

        //        private static void Inbox_OnNewMessagesArrived(object sender, IdleEventArgs e)
        //        {
        //            // Show a dialog
        //            MessageBox.Show($"A new message was downloaded in {e.Folder.Name} folder.");
        //        }

        //        public static MessageCollection GetMessagesForFolder(string name)
        //        {
        //            client.Folders[name].Messages.Download(); // Start the download process;
        //            return client.Folders[name].Messages;
        //        }
        //    }
    }
}
