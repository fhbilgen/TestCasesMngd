using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Configuration;

namespace BuggerNet
{
    public partial class frmTCPHost : Form
    {

        public static RichTextBox statRTB;
        public static ManualResetEvent m_Stop = new ManualResetEvent(false);
        public frmTCPHost()
        {
            InitializeComponent();
            tbPID.Text = Process.GetCurrentProcess().Id.ToString();
            statRTB = rtbStatus;
        }



        public static void TCPSocketServer()
        {
            string data = null;

            // Data buffer for incoming data.  
            byte[] bytes = new Byte[1024];

            int portNumber;
            Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;

            if (!string.IsNullOrEmpty(confCollection["TCPPort"].Value))
                Int32.TryParse(confCollection["TCPPort"].Value, out portNumber);
            else
            {
                MessageBox.Show("TCPPort is not set in the config file!!!", "BuggerNET");
                return;
            }

            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, portNumber);

            TcpListener tcpListener = new TcpListener(localEndPoint);
            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try
            {
                tcpListener.Start();
                // Start listening for connections.  
                while (true)
                {
                    //statRTB.AppendText("Waiting for a connection...\n");

                    while (!tcpListener.Pending())
                    {
                        System.Threading.Thread.Sleep(20);
                    }

                    // Program is suspended while waiting for an incoming connection.                      
                    Socket handler = tcpListener.AcceptSocket();
                    handler.Blocking = false;
                    data = null;

                    // An incoming connection needs to be processed.  
                    int count = 0;
                    while (/*count < 100000 && !m_Stop.WaitOne(0)*/ true )
                    {
                        bytes = new byte[1024];
                        data = null;
                        SocketError socketError = SocketError.Success;
                        //try
                        //{
                            while (handler.Receive(bytes, 0, bytes.Length, SocketFlags.None, out socketError) <= 0)
                            {
                                //
                                //System.Threading.Thread.Sleep(20);                            
                            }

                        //}
                        //catch (Exception ex1)
                        //{
                        //    string str = ex1.ToString();
                        //}

                        data = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

                        //statRTB.AppendText(string.Format("Text received : {0}\n", data));
                        bytes = null;
                        
                        count++;
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception ex)
            {
                statRTB.AppendText(ex.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(TCPSocketServer);
            thread.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_Stop.Set();
        }
    }
}
