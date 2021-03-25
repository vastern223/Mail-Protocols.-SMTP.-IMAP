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

namespace MailSen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Info_send info_Send = new Info_send();


        public MainWindowInfo_send info)
        {
            InitializeComponent();
            info_Send = info;
        }

        private void byttonSend_Click(object sender, RoutedEventArgs e)
        {
            if (Totext.Text != "" && themeText.Text != "")
            {
                MailMessage message = new MailMessage(info_Send.emailClient, Totext.Text, themeText.Text, bodyText.Text);
                if (checkboxPriority.IsChecked == true)
                {
                    message.Priority = MailPriority.High;
                }
                else
                {
                    message.Priority = MailPriority.Low;
                }
                if (ListAttachFile.Items.Count != 0)
                {
                    foreach (var item in ListAttachFile.Items)
                    {
                        message.Attachments.Add(new Attachment(item.ToString()));
                    }
                }
                ListAttachFile.Items.Clear();

                SmtpClient client = new SmtpClient(info_Send.emailClient, info_Send.port);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(info_Send.emailClient, info_Send.pasword);
                client.SendAsync(message, null);
                MessageBox.Show($"Message was sent!");
            }
        }

        private void byttonAttach_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPEG Files (.jpeg)|.jpeg|PNG Files (.png)|.png|JPG Files (.jpg)|.jpg|GIF Files (.gif)|.gif|Text documents|*.txt";
            dlg.DefaultExt = ".txt";
            if (dlg.ShowDialog() == true)
            {
                ListAttachFile.Items.Add(dlg.FileName);
            }
        }

        private void byttonLetter_Click(object sender, RoutedEventArgs e)
        {
            Totext.Text = null;
            bodyText.Text = null;
            themeText.Text = null;
            ListAttachFile.Items.Clear();
        }
    }
}
