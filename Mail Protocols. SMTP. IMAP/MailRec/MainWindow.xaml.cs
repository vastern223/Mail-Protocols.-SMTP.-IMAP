using EAGetMail;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace MailRec
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        static Info_send info_Send = new Info_send();
        public MainWindow()
        {
            InitializeComponent();
        }
        MailClient client;
        private void login_Click(object sender, RoutedEventArgs e)
        {


            if (NameMail.Text != "" && textPassword.Password != "")
            {
                info_Send.Mail = NameMail.Text;
                info_Send.pasword = textPassword.Password;
                if (Gmail.IsChecked == true)
                {
                    info_Send.emailClient = ConfigurationManager.AppSettings["gmail_server"];
                    info_Send.port = int.Parse(ConfigurationManager.AppSettings["gmail_port"]);
                    info_Send.portmp = int.Parse(ConfigurationManager.AppSettings["gmail_portMp"]);
                    info_Send.emailClientMp = ConfigurationManager.AppSettings["gmail_serverMp"];
                }
                else if (ukrnet.IsChecked == true)
                {
                    info_Send.emailClient = ConfigurationManager.AppSettings["ukr_server"];
                    info_Send.port = int.Parse(ConfigurationManager.AppSettings["ukr_port"]);
                    info_Send.portmp = int.Parse(ConfigurationManager.AppSettings[" ukr_portMp"]);
                    info_Send.emailClientMp = ConfigurationManager.AppSettings["ukr_serverMp"];
                }
                Console.WriteLine("Login secsesful");
                login.IsEnabled = false;



                MailServer server = new MailServer(
                     info_Send.emailClientMp,
                      info_Send.Mail,
                       info_Send.pasword,
                    ServerProtocol.Imap4)
                {
                    SSLConnection = true,
                    Port = info_Send.portmp
                };

                client = new MailClient("TryIt"); // trial version

                try
                {

                    client.Connect(server);

                    foreach (var f in client.GetFolders())
                    {
                        folderText.Items.Add(f.Name);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void message_Click(object sender, RoutedEventArgs e)
        {
            MailSen mailSe = new MailSen(info_Send);
            mailSe.Show();
        }

        private void folderText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bodymessegeText.Items.Clear();
            foreach (var f in client.GetFolders())
            {
                if (f.Name == folderText.SelectedItem.ToString())
                {                   
                    foreach (var subF in f.SubFolders)
                    {
                        bodymessegeText.Items.Add("\t" + subF.Name);
                    }
                }
            }
        }

        private void bodymessegeText_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            messegeText.Items.Clear();
           
            client.SelectFolder(client.Imap4Folders[folderText.SelectedIndex].SubFolders[bodymessegeText.SelectedIndex]);
            // get mails in selected folder
            var messages = client.GetMailInfos();

            foreach (var m in messages)
            {
                Mail message = client.GetMail(m);
                messegeText.Items.Add( $"Index: {m.Index}{Environment.NewLine}Size: {m.Size}\n From: {message.From}\n\t{message.Subject} Date: {message.SentDate}\tAttachments: {message.Attachments.Count()}Body: {(message.TextBody)}");
            }
        }
    }
}




