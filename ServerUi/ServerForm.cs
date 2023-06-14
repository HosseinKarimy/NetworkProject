using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ServerUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public Socket ServerListener { get; set; }
        public Socket ClientSocket { get; set; }
        public Thread ListenerThread { get; set; }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ipAdders = IPAddress.Parse("192.168.1.100");
                IPEndPoint localEndPoint = new IPEndPoint(ipAdders, 11111);
                ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ServerListener.Bind(localEndPoint);
                ServerListener.Listen(2);

                RichTextBox_Logs.Text += $"Server Started...{localEndPoint}\n";

                ListenerThread = new Thread(() => Listener());
                ListenerThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Listener()
        {
            while (true)
            {
                try
                {
                    ClientSocket = ServerListener.Accept();

                    Invoke(new Action(() => { RichTextBox_Logs.Text += $"Client with EndPoint: {ClientSocket.RemoteEndPoint} connected! ({DateTime.Now})\n"; }));


                    byte[] bytes = new Byte[1024];
                    int numByte = ClientSocket.Receive(bytes);

                    string ReceivedMessage = Encoding.ASCII.GetString(bytes, 0, numByte);

                    (string UserName, string NewText) = SplitMessage(ReceivedMessage);

                    File.AppendAllText($"{UserName}.txt", NewText);
                    var context = File.ReadAllText($"{UserName}.txt");

                    byte[] data = Encoding.ASCII.GetBytes(context);
                    ClientSocket.Send(data);
                }
                catch (Exception)
                {
                    
                }
                finally
                {
                    ClientSocket?.Close();
                }
            }

        }

        private (string UserName, string NewText) SplitMessage(string received)
        {
            string[] lines = received.Split('\n');
            return (lines[0], received.Substring(lines[0].Length + 1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ServerListener.Close();
                ClientSocket.Close();
                ListenerThread.Abort();
                RichTextBox_Logs.Text += $"Server Shutdown...\n";
            }
            catch (Exception )
            {                
            }        
        }
    }
}
