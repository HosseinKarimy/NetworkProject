using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientUi
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        public Socket Client { get; set; }

        private void Button_Process_Click(object sender, EventArgs e)
        {
            try
            {
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ipAdders = IPAddress.Parse("192.168.1.100");
                IPEndPoint localEndPoint = new IPEndPoint(ipAdders, 54321);

                Client.Connect(localEndPoint);

                var message = MergeMessage();
                
                byte[] data = Encoding.ASCII.GetBytes(message);
                Client.Send(data);

                byte[] context = new byte[1024];
                int numByte = Client.Receive(context);

                RichTextBox_AllContext.Text = Encoding.ASCII.GetString(context, 0, numByte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Client.Close();
            }
        }

        private string MergeMessage()
        {
            return TextBox_UserName.Text + '\n' + TextBox_NewText.Text;
        }
    }
}
