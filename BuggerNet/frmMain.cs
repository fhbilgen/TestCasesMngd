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

        private void fileBeingUsedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFSConstructor frmFSConstructor = new frmFSConstructor();
            frmFSConstructor.ShowDialog();
        }

        private void threadUnsafeGDAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenericDictionary frmGenericDictionary = new frmGenericDictionary();
            frmGenericDictionary.ShowDialog();
        }

        private void constantCPUUsageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHogCPU frmHogCPU = new frmHogCPU();
            frmHogCPU.ShowDialog();
        }

        private void testsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemoryTests frmMemoryTests = new frmMemoryTests();
            frmMemoryTests.ShowDialog();
        }

        private void connectToTCPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTCPClient frmTCPClient = new frmTCPClient();
            frmTCPClient.ShowDialog();
        }

        private void startTCPServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTCPHost frmTCPHost = new frmTCPHost();
            frmTCPHost.ShowDialog();
        }

        private void longListAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWrongDelete frmWrongDelete = new frmWrongDelete();
            frmWrongDelete.ShowDialog();
        }

        private void serviceHostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFHost frmWCFHost = new frmWCFHost();
            frmWCFHost.ShowDialog();
        }

        private void loadTestClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFLoadTest frmWCFLoadTest = new frmWCFLoadTest();
            frmWCFLoadTest.ShowDialog();
        }

        private void secureClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFSecureClient frmWCFSecureClient = new frmWCFSecureClient();
            frmWCFSecureClient.ShowDialog();
        }

        private void singleTestClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFSingleTest frmWCFSingleTest = new frmWCFSingleTest();
            frmWCFSingleTest.ShowDialog();
        }

        private void proxyProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWCFPrxProblem frmWCFPrxProblem = new frmWCFPrxProblem();
            frmWCFPrxProblem.ShowDialog();
        }
    }
}
