using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuggerNetEng.Helpers
{
    public class GCNotificationHelper
    {
        private readonly int MB = 1024 * 1024;
        private readonly int KB = 1024;

        private int ArrSize { get; set; }
        private int Gen2Threshold { get; set; }
        private int LOHThreshold { get; set; }
        private int GCNotificationTimeout { get; set; }
        private TextBox TxtBoxMem { get; set; }
        private ListView LvNotifications { get; set; }

        private int MemSize = 0;        
        
        private readonly ManualResetEvent EvtGCAlloc = new ManualResetEvent(false);
        private readonly List<byte[]> arrays = new List<byte[]>();
        

        private delegate void SafeCallTBDelegate(string text);
        private delegate void SafeCallLVDelegate(string text);

        public GCNotificationHelper() => ArrSize = MB; // the default

        public GCNotificationHelper(int allocSize, TextBox tb, ListView lv, int gen2th, int lohth, int gcnottm)
        {
            ArrSize = allocSize * MB;
            TxtBoxMem = tb;
            LvNotifications = lv;
            Gen2Threshold = gen2th;
            LOHThreshold = lohth;
            GCNotificationTimeout = gcnottm;
        }

        public void StopAllocation() => EvtGCAlloc.Set();

        public void AllocMemory()
        {
            while (!EvtGCAlloc.WaitOne(0))
            {
                try
                {                   
                    arrays.Add(new byte[KB*ArrSize]);
                    MemSize += (ArrSize / MB);
                    UpdateTextBox($"{MemSize}");
                }
                catch (OutOfMemoryException)
                {
                    arrays.Clear();
                }
            }
        }

        public void UpdateTextBox(string text)
        {
            if (TxtBoxMem.InvokeRequired)
            {
                var d = new SafeCallTBDelegate(UpdateTextBox);
                TxtBoxMem.Invoke(d, new object[] { text });
            }
            else
                TxtBoxMem.Text = text;
        }

        public void WaitForGCNotification()
        {
            //const int MaxWaitMs = 1000;
            while (!EvtGCAlloc.WaitOne(0))           
            {
                GCNotificationStatus status = GC.WaitForFullGCApproach(GCNotificationTimeout);

                bool didCollect = false;
                switch (status)
                {
                    case GCNotificationStatus.Succeeded:
                        UpdateListView("GC approaching!");
                        didCollect = true;
                        GC.Collect();
                        break;

                    case GCNotificationStatus.Canceled:
                        UpdateListView("GC Notification was cancelled!");
                        break;

                    case GCNotificationStatus.Timeout:
                        UpdateListView("GC Notification timed out!");
                        break;

                }

                if (didCollect)
                {
                    do
                    {
                        status = GC.WaitForFullGCApproach(GCNotificationTimeout);
                        switch (status)
                        {
                            case GCNotificationStatus.Succeeded:
                                UpdateListView("GC completed!");
                                break;

                            case GCNotificationStatus.Canceled:
                                UpdateListView("GC Notification was cancelled!");
                                break;

                            case GCNotificationStatus.Timeout:  
                                UpdateListView("GC Notification timed out!");
                                break;

                        }

                    } while (status == GCNotificationStatus.Timeout && !EvtGCAlloc.WaitOne(0));
                }
            }
        }

        public void UpdateListView(string text)
        {
            if (LvNotifications.InvokeRequired)
            {
                var d = new SafeCallLVDelegate(UpdateListView);
                LvNotifications.Invoke(d, new object[] { text });
            }
            else
            {
                var item = new ListViewItem
                {
                    Text = text
                };
                LvNotifications.Items.Add(item);                
            }
        }

        public void StartGCNotificationDemo()
        {
            GC.RegisterForFullGCNotification(Gen2Threshold, LOHThreshold);
            
            List<Thread> threads = new List<Thread>
            {
                new Thread(new ThreadStart(AllocMemory)),
                new Thread(new ThreadStart(WaitForGCNotification))
            };

            foreach (var th in threads)
                th.Start();

            foreach (var th in threads)
                th.Join();

            arrays.Clear();
            MemSize = 0;
            UpdateTextBox($"{MemSize}");
            TxtBoxMem = null;
            LvNotifications = null;
            GC.CancelFullGCNotification();
            GC.Collect(2, GCCollectionMode.Forced);
        }
    }
}
