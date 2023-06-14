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

                IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

                Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                listener.Bind(localEndPoint);
                listener.Listen(10);

                RichTextBox_Logs.Text += $"Server Started with ip:{ipAddr.Address.ToString()} Port: 11111";

                Thread thread = new Thread(() => Listener(listener));
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Listener(Socket listener)
        {
            while (true)
            {
                Socket Socket = listener.Accept();

                


                byte[] bytes = new Byte[1024];
                int numByte = Socket.Receive(bytes);

                string message = Encoding.ASCII.GetString(bytes, 0, numByte);



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
                using (var streamWriter = new StreamWriter($"{UserName}.txt", false))
                {
                    streamWriter.WriteLine(context);
                }

                byte[] data = Encoding.ASCII.GetBytes(context);
                Socket.Send(data);

                Socket.Shutdown(SocketShutdown.Both);
                Socket.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
