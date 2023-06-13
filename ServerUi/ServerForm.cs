using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress iPAddress = IPAddress.Parse(TextBox_IpAddress.Text);
                int port = int.Parse(TextBox_Port.Text);
                TcpListener tcpListener = new TcpListener(iPAddress, port);
                tcpListener.Start();

                RichTextBox_Logs.Text += $"Server Started with ip:{iPAddress} Port: {TextBox_Port.Text}";

                Thread thread = new Thread(() => Listener(tcpListener));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Listener(TcpListener tcpListener)
        {
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Invoke(new Action(() => { RichTextBox_Logs.Text += $"\nClient with Ip Address {client.Client.RemoteEndPoint} Connected!"; }));
                client.ReceiveBufferSize = 4096;
                client.SendBufferSize = 4096;
                NetworkStream stream = client.GetStream();

                byte[] data = new byte[4096];
                int bytes = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytes);

                string[] lines = message.Split('\n');
                string UserName = lines[0];
                message = message.Substring(UserName.Length + 1);

                string context = " ";
                if (File.Exists($"{UserName}.txt"))
                {
                   context = File.ReadAllText($"{UserName}.txt");
                }
                else
                {
                   File.Create($"{UserName}.txt").Close();
                }
                context += message;
                using (var streamWriter = new StreamWriter($"{UserName}.txt",false))
                {
                    streamWriter.Write(context);
                }

                data = Encoding.ASCII.GetBytes(context);
                stream.Write(data, 0, data.Length);
            }
        }
    }
}
