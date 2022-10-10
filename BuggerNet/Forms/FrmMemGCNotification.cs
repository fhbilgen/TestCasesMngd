using BuggerNetEng.Engine;
using BuggerNetEng.Helpers;
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

// 
// The following article was used to perform the multithread UI update in a safe way
// https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-make-thread-safe-calls-to-windows-forms-controls?view=netframeworkdesktop-4.8&redirectedfrom=MSDN
// 
// The following article helped to add values in to the ListView
// https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.listviewitem.subitems?view=windowsdesktop-7.0
//
// The following article is useful for UI based Timers
// https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.timer?view=windowsdesktop-6.0&viewFallbackFrom=netcore-3.1
//

namespace BuggerNet.Forms
{
    public partial class FrmMemGCNotification : Form
    {
        GCNotificationHelper gcNtfHelper;
        CLRMemPCHelper memPC;
        private delegate void SafeCallLVDelegate(string[] txtArr);

        public FrmMemGCNotification()
        {
            InitializeComponent();
            InitializeGCEventView();
            InitializePCView();
        }

        private void BtnGCNtfStart_Click(object sender, EventArgs e)
        {
            PrepareRun();
            Run();            
        }

        private void BtnGCNtfStop_Click(object sender, EventArgs e)
        {
            gcNtfHelper.StopAllocation();
            this.tmrPCRefresh.Stop();
        }

        private void PrepareRun()
        {
            int.TryParse(tbMemDelta.Text, out int deltaMem);
            int.TryParse(tbPlFreq.Text, out int notifTm);
            int.TryParse(tbPCFreq.Text, out int pcFreq);
            
            gcNtfHelper = new GCNotificationHelper(deltaMem, tbAllocMem, lvGCEvents, tcbGen2.Value, tcbLOHTh.Value, notifTm);

            memPC = new CLRMemPCHelper();
            this.tmrPCRefresh.Interval = pcFreq * 1000;
            this.tmrPCRefresh.Enabled = true;
        }

        private void Run()
        {
            Thread t = new Thread(new ThreadStart(gcNtfHelper.StartGCNotificationDemo));
            t.Start();
        }

        private void InitializeGCEventView()
        {
            this.lvGCEvents.Columns.Add("Notifications");
            this.lvGCEvents.Columns[0].Width = (int)(this.lvGCEvents.Width * 0.9);
        }

        private void InitializePCView()
        {
            this.lvPC.Columns.Add("Counter Name");
            this.lvPC.Columns.Add("Value");
            this.lvPC.Columns[0].Width = (int)(this.lvPC.Width * 0.5);
            this.lvPC.Columns[1].Width = (int)(this.lvPC.Width * 0.45);

            for (int i = 0; i != CLRMemPCHelper.CounterNames.Length; i++)
            {
                var lvItem = new ListViewItem(CLRMemPCHelper.CounterNames[i]);
                lvItem.SubItems.Add("0.0");
                this.lvPC.Items.Add(lvItem);
            }
        }

        private void TmrPCRefresh_Tick(object sender, EventArgs e)
        {
            var values = memPC.GetNextCounterValues();
            UpdateListView(values);
        }

        public void UpdateListView(string[] txtArr)
        {
            if (lvPC.InvokeRequired)
            {
                var d = new SafeCallLVDelegate(UpdateListView);
                lvPC.Invoke(d, new object[] { txtArr });
            }
            else
                for (int i = 0; i != CLRMemPCHelper.CounterNames.Length; i++)
                
                    lvPC.Items[i].SubItems[1].Text = txtArr[i];                
        }

    }
}
