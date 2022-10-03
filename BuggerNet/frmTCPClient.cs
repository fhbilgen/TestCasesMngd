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
using System.Threading;
using System.Configuration;

namespace BuggerNet
{
    public partial class frmTCPClient : Form
    {
        public static ManualResetEvent m_Stop = new System.Threading.ManualResetEvent(false);
        public static RichTextBox statRTB;
        public frmTCPClient()
        {
            InitializeComponent();
            statRTB = rtbStatus;
        }

        public static void TCPSocketClient()
        {
            // Data buffer for incoming data.  
            byte[] bytes = new byte[1024];

            // Connect to a remote device.  
            try
            {
                int portNumber;
                Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;

                if (!string.IsNullOrEmpty(confCollection["TCPPort"].Value))
                    Int32.TryParse(confCollection["TCPPort"].Value, out portNumber);
                else
                {
                    MessageBox.Show( "TCPPort is not set in the config file!!!", "BuggerNET");
                    return;
                }
                // Establish the remote endpoint for the socket.  
                // This example uses port 11000 on the local computer.  
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, portNumber);

                // Create a TCP/IP  socket.  
                Socket senderTCP = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                senderTCP.Connect(remoteEP);
                int count = 0;
                // Connect the socket to the remote endpoint. Catch any errors.  
                while (count < 100000 && !m_Stop.WaitOne(0))
                {
                    try
                    {

                        //statRTB.AppendText(string.Format("Socket connected to {0}\n", senderTCP.RemoteEndPoint.ToString()));

                        // Encode the data string into a byte array.  
                        byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                        // Send the data through the socket.  
                        int bytesSent = senderTCP.Send(msg);

                    }
                    catch (ArgumentNullException ane)
                    {
                        statRTB.AppendText(string.Format("ArgumentNullException : {0}", ane.ToString()));
                    }
                    catch (SocketException se)
                    {
                        statRTB.AppendText(string.Format("SocketException : {0}", se.ToString()));
                    }
                    catch (Exception ex)
                    {
                        statRTB.AppendText(string.Format("Unexpected exception : {0}", ex.ToString()));
                    }

                    System.Threading.Thread.Sleep(1000);
                    count++;
                }

           
            }
            catch (Exception exc)
            {
                statRTB.AppendText(exc.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(TCPSocketClient);
            thread.Start();
        }




        private void btnSTOP_Click(object sender, EventArgs e)
        {
            m_Stop.Set();
        }
    }
}
