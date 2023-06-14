using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace ClientUi
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void Button_Process_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

                Socket client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(localEndPoint);

                //send message to server
                var message = $"{TextBox_UserName.Text}\n";
                message += TextBox_NewText.Text;
                byte[] messageSent = Encoding.ASCII.GetBytes(message);
                int byteSent = client.Send(messageSent);

                byte[] messageReceived = new byte[1024];
                int byteRecv = client.Receive(messageReceived);

                RichTextBox_AllContext.Text = Encoding.ASCII.GetString(messageReceived,0, byteRecv);

                client.Shutdown(SocketShutdown.Both);
                client.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
