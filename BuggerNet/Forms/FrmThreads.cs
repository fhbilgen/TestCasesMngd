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
using System.IO;
using BuggerNetEng.Helpers;
using System.Diagnostics;
using System.ServiceModel.Channels;
using BuggerNetEng.Engine;

namespace BuggerNet.Forms
{
    public partial class FrmThreads : Form
    {
        private delegate void SafeCallLVDelegate(string text);
        private delegate void SafeCallTLVDelegate(List<ListViewItem> itemList);
        private List<ListViewItem> threadItemList = new List<ListViewItem>();

        public FrmThreads()
        {
            InitializeComponent();
            lvOutput.Columns.Add("Threads' output");
            lvOutput.Columns[0].Width = (int)(0.9 * lvOutput.Width);
                       
            for(int i = 0; i!= ThreadHelper.ThreadListHeaders.Length; i++)
            {
                lvThreads.Columns.Add(ThreadHelper.ThreadListHeaders[i]);
                lvThreads.Columns[i].TextAlign = HorizontalAlignment.Right;                
                lvThreads.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                lvThreads.Columns[i].Width = -2;
            }            
        }


        private bool IsBackground()
        {
            return rbBackground.Checked;
        }
        private string ThreadName()
        {
            return tbName.Text;
        }

        private void UpdateListView(string text)
        {
            if (lvOutput.InvokeRequired)
            {
                var d = new SafeCallLVDelegate(UpdateListView);
                lvOutput.Invoke(d, new object[] { text });
            }
            else
                lvOutput.Items.Add(text);                    
        }

        private void UpdateThreadLV(List<ListViewItem> itemList)
        {
            if (lvThreads.InvokeRequired)
            {
                var d = new SafeCallTLVDelegate(UpdateThreadLV);
                lvThreads.Invoke(d, new object[] { itemList });
            }
            else
            {
                lvThreads.Items.Clear();

                foreach (ListViewItem lvi in itemList)
                    lvThreads.Items.Add(lvi);

                for (int i = 0; i != ThreadHelper.ThreadListHeaders.Length; i++)
                {
                    lvThreads.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    //lvThreads.Columns[i].Width = -2;
                }
            }
        }        

        private void GetThreadInfo()
        {
            threadItemList.Clear();
            int c = 0;
            foreach (ProcessThread pt in System.Diagnostics.Process.GetCurrentProcess().Threads)
            {
                var wr = pt.ThreadState == System.Diagnostics.ThreadState.Wait ? pt.WaitReason.ToString() : "N/A";

                var lvi = new ListViewItem($"{c++}");                
                lvi.SubItems.Add($"{pt.Id}");
                lvi.SubItems.Add($"{pt.ThreadState}");
                lvi.SubItems.Add($"{pt.BasePriority}");
                lvi.SubItems.Add($"{pt.CurrentPriority}");
                lvi.SubItems.Add($"{pt.PriorityBoostEnabled}");
                lvi.SubItems.Add($"{pt.PriorityLevel}");
                lvi.SubItems.Add($"{pt.PrivilegedProcessorTime}");
                lvi.SubItems.Add($"{pt.TotalProcessorTime}");
                lvi.SubItems.Add($"{pt.StartTime}");
                lvi.SubItems.Add($"{wr}");
                
                threadItemList.Add(lvi);
            }
        }

        private void BtnStartTh_Click(object sender, EventArgs e)
        {
            var thr = new Thread(() =>
            {
                while (true)
                {
                    string str = "Drive thread: ";
                    foreach (var drv in DriveInfo.GetDrives())
                        str += drv.Name;
                    UpdateListView($"New thread: {Win32APIs.GetCurrentThreadId()} {str}");
                    Thread.Sleep(100);
                }
            });
            thr.IsBackground = this.IsBackground();
            if (this.ThreadName() != String.Empty)
                thr.Name = this.ThreadName();

            thr.Start();

            for (int i = 0; i != 10; i++)
            {
                UpdateListView($"UI thread: {Win32APIs.GetCurrentThreadId()} is executing");
                Task.Delay(500);
            }

            this.tmrThInfo.Enabled = true;
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TmrThInfo_Tick(object sender, EventArgs e)
        {
            GetThreadInfo();
            UpdateThreadLV(threadItemList);
        }
    }
}
