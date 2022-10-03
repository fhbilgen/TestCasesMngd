using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BuggerNetEng;

namespace BuggerNet
{
    public partial class frmHogCPU : Form
    {
        public static Thread m_thread;
        public static ManualResetEvent m_Stop = new ManualResetEvent(false);

        public frmHogCPU()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int Duration;

            if (!string.IsNullOrEmpty(tbDuration.Text))
                Int32.TryParse(tbDuration.Text, out Duration);
            else
                Duration = 0;

            m_thread = new Thread(StartResourcePool);
            m_thread.Start(Duration);


        }


        public static void StartResourcePool(object duration)
        {
            ResourcePool rp = new ResourcePool();

            rp.Initialize();
            rp.StartPoolManagerFunc((int)duration);
            m_Stop.WaitOne(-1);
            rp.m_thread.Abort();
            m_thread.Join();
            m_Stop.Reset();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_Stop.Set();
        }
    }
}
