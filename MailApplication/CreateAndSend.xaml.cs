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
using System.Net;
using System.Net.Mail;

namespace MailApplication
{
    /// <summary>
    /// Interaction logic for CreateAndSend.xaml
    /// </summary>
    public partial class CreateAndSend : Page
    {
        public CreateAndSend()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            // You should use a using statement
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 25))
            {
                // Configure the client
                client.EnableSsl = true;
                //videorentproject@gmail.com
                //moviesOscar100%
                client.Credentials = new NetworkCredential("videorentproject", "moviesOscar100%");
                // client.UseDefaultCredentials = true;

                // A client has been created, now you need to create a MailMessage object
                MailMessage message = new MailMessage(
                                         "videorentproject@gmail.com", // From field
                                         to.Text, // Recipient field
                                         subject.Text, // Subject of the email message
                                         body.Text // Email message body
                                      );

                // Send the message
                client.Send(message);

                HomePage.ClearRoom(); // Clear the room once email has been sent. 
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            HomePage.ClearRoom();
        }
    }
}
