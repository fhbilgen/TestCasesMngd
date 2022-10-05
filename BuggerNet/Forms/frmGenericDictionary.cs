using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuggerNetEng;


namespace BuggerNet
{
    public partial class frmGenericDictionary : Form
    {

        public static int m_ThreadCount;
        public static int m_CountOfElements;
        public static Dictionary<int, string> m_Dict = new Dictionary<int, string>();
        public static Thread[] m_clientThreads;
        public static ManualResetEvent m_Stop = new ManualResetEvent(false);
        public Boolean m_WalkThreadRunning = false;
        public frmGenericDictionary()
        {
            InitializeComponent();
        }

        private void UpdateResult(string strText)
        {
            rtbResult.AppendText(strText + "\n\r");
        }

        private void StartWalkThread()
        {
            Thread thread;

            m_WalkThreadRunning = true;

            thread = new Thread(WalkDictionary);
            thread.Start();
        }

        public static void DeleteSome()
        {
            try
            {
                m_Dict.Remove(90);
            }
            catch(Exception ex)
            { }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            string strOutput;
            
            m_Stop.Reset();

            if (!string.IsNullOrEmpty(tbThreads.Text))
                Int32.TryParse(tbThreads.Text, out m_ThreadCount);
            else
                m_ThreadCount = 0;

            if (!string.IsNullOrEmpty(tbElementCount.Text))
                Int32.TryParse(tbElementCount.Text, out m_CountOfElements);
            else
                m_CountOfElements = 0;

            m_clientThreads = new Thread[m_ThreadCount];
            //m_Dict = new Dictionary<int, string>(m_CountOfElements * m_ThreadCount);

            for (int i=0; i!=m_ThreadCount;i++)
            {
                m_clientThreads[i] = new Thread(InsertToDictionary);
                m_clientThreads[i].Start(i);
            }

            //if (!m_WalkThreadRunning)
            //    StartWalkThread();
            
            for (int i = 0; i != m_ThreadCount; i++)
            {
                m_clientThreads[i].Join();
            }

            strOutput = "Number of elements in the Dictionary = " + m_Dict.Count.ToString();

            UpdateResult(strOutput);
        }

        public static void InsertToDictionary(object start)
        {
            int s, e;
            s = m_CountOfElements * (Int32)start;
            e = s + m_CountOfElements;
            for(int i =s; i!=e;i++)
            {
                try
                {
                    //if (!m_Dict.ContainsKey(i))
                    m_Dict.Add(i, "01234567890123456789012345678901234567890123456789");
                }
                catch(Exception ex)
                {

                }
            }
        }

        public static void WalkDictionary()
        {
            while (true)
            {
                try
                {
                    foreach (KeyValuePair<int, string> kp in m_Dict)
                    {
                    
                        if (kp.Value.Equals("ABC"))
                            break;                 
                    }
                }
                catch (Exception ex)
                {
                }
                DeleteSome();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            m_Dict.Clear();
            rtbResult.Clear();
        }
    }
}
