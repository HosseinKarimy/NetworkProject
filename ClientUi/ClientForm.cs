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
                //client
                TcpClient tcpClient = new TcpClient(TextBox_IpAddress.Text, int.Parse(TextBox_Port.Text));
                tcpClient.ReceiveBufferSize = 4096;
                tcpClient.SendBufferSize = 4096;
                //stream
                NetworkStream stream = tcpClient.GetStream();

                //send message to server
                
                var message = $"{TextBox_UserName.Text}\n";
                message += TextBox_NewText.Text;
                byte[] data = new byte[4096];
                data = Encoding.ASCII.GetBytes(message);
                stream.Write(data, 0, data.Length);
                
                Thread.Sleep(3000);

                //read result
                var bytes = stream.Read(data, 0, data.Length);
                var response = Encoding.ASCII.GetString(data, 0, bytes);

                RichTextBox_AllContext.Text = response;

                stream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
