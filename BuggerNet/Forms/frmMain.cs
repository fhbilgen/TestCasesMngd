using BuggerNet.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuggerNet
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FileBeingUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFSConstructor frmFSConstructor = new frmFSConstructor();
            frmFSConstructor.ShowDialog();
        }

        private void ThreadUnsafeGDAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenericDictionary frmGenericDictionary = new frmGenericDictionary();
            frmGenericDictionary.ShowDialog();
        }

        private void ConstantCPUUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHogCPU frmHogCPU = new frmHogCPU();
            frmHogCPU.ShowDialog();
        }

        private void TestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemoryTests frmMemoryTests = new frmMemoryTests();
            frmMemoryTests.ShowDialog();
        }

        private void ConnectToTCPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTCPClient frmTCPClient = new frmTCPClient();
            frmTCPClient.ShowDialog();
        }

        private void StartTCPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTCPHost frmTCPHost = new frmTCPHost();
            frmTCPHost.ShowDialog();
        }

        private void LongListAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWrongDelete frmWrongDelete = new frmWrongDelete();
            frmWrongDelete.ShowDialog();
        }

        private void ServiceHostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFHost frmWCFHost = new frmWCFHost();
            frmWCFHost.ShowDialog();
        }

        private void LoadTestClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFLoadTest frmWCFLoadTest = new frmWCFLoadTest();
            frmWCFLoadTest.ShowDialog();
        }

        private void SecureClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFSecureClient frmWCFSecureClient = new frmWCFSecureClient();
            frmWCFSecureClient.ShowDialog();
        }

        private void SingleTestClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFSingleTest frmWCFSingleTest = new frmWCFSingleTest();
            frmWCFSingleTest.ShowDialog();
        }

        private void ProxyProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFPrxProblem frmWCFPrxProblem = new frmWCFPrxProblem();
            frmWCFPrxProblem.ShowDialog();
        }

        private void BenchmarkDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmBnchmrkDm();
            frm.ShowDialog();
        }

        private void NewObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCreateObj();
            frm.ShowDialog();
        }

        private void GCNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMemGCNotification();
            frm.ShowDialog();
        }

        private void BackgroundVsForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmThreads();
            frm.ShowDialog();
        }
    }
}
