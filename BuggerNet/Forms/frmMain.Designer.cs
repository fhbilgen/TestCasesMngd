namespace BuggerNet
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constantCPUUsageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longListAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadUnsafeGDAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTCPServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToTCPServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longServiceResponseTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benchmarkDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wAITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooLowRequestssecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unresponsiveUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCEPTIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileBeingUsedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wCFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceHostingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadTestClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleTestClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secureClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gCNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memoryToolStripMenuItem,
            this.cPUToolStripMenuItem,
            this.wAITToolStripMenuItem,
            this.eXCEPTIONSToolStripMenuItem,
            this.wCFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memoryToolStripMenuItem
            // 
            this.memoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testsToolStripMenuItem,
            this.newObjectToolStripMenuItem,
            this.gCNotificationToolStripMenuItem});
            this.memoryToolStripMenuItem.Name = "memoryToolStripMenuItem";
            this.memoryToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.memoryToolStripMenuItem.Text = "MEMORY";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testsToolStripMenuItem.Text = "Tests";
            this.testsToolStripMenuItem.Click += new System.EventHandler(this.TestsToolStripMenuItem_Click);
            // 
            // newObjectToolStripMenuItem
            // 
            this.newObjectToolStripMenuItem.Name = "newObjectToolStripMenuItem";
            this.newObjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newObjectToolStripMenuItem.Text = "New Object";
            this.newObjectToolStripMenuItem.Click += new System.EventHandler(this.NewObjectToolStripMenuItem_Click);
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constantCPUUsageToolStripMenuItem,
            this.longListAccessToolStripMenuItem,
            this.threadUnsafeGDAccessToolStripMenuItem,
            this.startTCPServerToolStripMenuItem,
            this.connectToTCPServerToolStripMenuItem,
            this.longServiceResponseTimeToolStripMenuItem,
            this.benchmarkDemoToolStripMenuItem});
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(42, 22);
            this.cPUToolStripMenuItem.Text = "CPU";
            // 
            // constantCPUUsageToolStripMenuItem
            // 
            this.constantCPUUsageToolStripMenuItem.Name = "constantCPUUsageToolStripMenuItem";
            this.constantCPUUsageToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.constantCPUUsageToolStripMenuItem.Text = "Constant CPU Usage";
            this.constantCPUUsageToolStripMenuItem.Click += new System.EventHandler(this.ConstantCPUUsageToolStripMenuItem_Click);
            // 
            // longListAccessToolStripMenuItem
            // 
            this.longListAccessToolStripMenuItem.Name = "longListAccessToolStripMenuItem";
            this.longListAccessToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.longListAccessToolStripMenuItem.Text = "Long List Access";
            this.longListAccessToolStripMenuItem.Click += new System.EventHandler(this.LongListAccessToolStripMenuItem_Click);
            // 
            // threadUnsafeGDAccessToolStripMenuItem
            // 
            this.threadUnsafeGDAccessToolStripMenuItem.Name = "threadUnsafeGDAccessToolStripMenuItem";
            this.threadUnsafeGDAccessToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.threadUnsafeGDAccessToolStripMenuItem.Text = "Thread Unsafe GD Access";
            this.threadUnsafeGDAccessToolStripMenuItem.Click += new System.EventHandler(this.ThreadUnsafeGDAccessToolStripMenuItem_Click);
            // 
            // startTCPServerToolStripMenuItem
            // 
            this.startTCPServerToolStripMenuItem.Name = "startTCPServerToolStripMenuItem";
            this.startTCPServerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.startTCPServerToolStripMenuItem.Text = "Start TCP Server";
            this.startTCPServerToolStripMenuItem.Click += new System.EventHandler(this.StartTCPServerToolStripMenuItem_Click);
            // 
            // connectToTCPServerToolStripMenuItem
            // 
            this.connectToTCPServerToolStripMenuItem.Name = "connectToTCPServerToolStripMenuItem";
            this.connectToTCPServerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.connectToTCPServerToolStripMenuItem.Text = "Connect to TCP Server";
            this.connectToTCPServerToolStripMenuItem.Click += new System.EventHandler(this.ConnectToTCPServerToolStripMenuItem_Click);
            // 
            // longServiceResponseTimeToolStripMenuItem
            // 
            this.longServiceResponseTimeToolStripMenuItem.Name = "longServiceResponseTimeToolStripMenuItem";
            this.longServiceResponseTimeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.longServiceResponseTimeToolStripMenuItem.Text = "Long Service Response Time";
            // 
            // benchmarkDemoToolStripMenuItem
            // 
            this.benchmarkDemoToolStripMenuItem.Name = "benchmarkDemoToolStripMenuItem";
            this.benchmarkDemoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.benchmarkDemoToolStripMenuItem.Text = "Benchmark Demo";
            this.benchmarkDemoToolStripMenuItem.Click += new System.EventHandler(this.BenchmarkDemoToolStripMenuItem_Click);
            // 
            // wAITToolStripMenuItem
            // 
            this.wAITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooLowRequestssecToolStripMenuItem,
            this.unresponsiveUIToolStripMenuItem});
            this.wAITToolStripMenuItem.Name = "wAITToolStripMenuItem";
            this.wAITToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.wAITToolStripMenuItem.Text = "WAIT";
            // 
            // tooLowRequestssecToolStripMenuItem
            // 
            this.tooLowRequestssecToolStripMenuItem.Name = "tooLowRequestssecToolStripMenuItem";
            this.tooLowRequestssecToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.tooLowRequestssecToolStripMenuItem.Text = "Too low requests/sec";
            // 
            // unresponsiveUIToolStripMenuItem
            // 
            this.unresponsiveUIToolStripMenuItem.Name = "unresponsiveUIToolStripMenuItem";
            this.unresponsiveUIToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.unresponsiveUIToolStripMenuItem.Text = "Cannot Log";
            // 
            // eXCEPTIONSToolStripMenuItem
            // 
            this.eXCEPTIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileBeingUsedToolStripMenuItem});
            this.eXCEPTIONSToolStripMenuItem.Name = "eXCEPTIONSToolStripMenuItem";
            this.eXCEPTIONSToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.eXCEPTIONSToolStripMenuItem.Text = "EXCEPTIONS";
            // 
            // fileBeingUsedToolStripMenuItem
            // 
            this.fileBeingUsedToolStripMenuItem.Name = "fileBeingUsedToolStripMenuItem";
            this.fileBeingUsedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.fileBeingUsedToolStripMenuItem.Text = "File being used...";
            this.fileBeingUsedToolStripMenuItem.Click += new System.EventHandler(this.FileBeingUsedToolStripMenuItem_Click);
            // 
            // wCFToolStripMenuItem
            // 
            this.wCFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceHostingToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadTestClientToolStripMenuItem,
            this.singleTestClientToolStripMenuItem,
            this.secureClientToolStripMenuItem,
            this.proxyProblemToolStripMenuItem});
            this.wCFToolStripMenuItem.Name = "wCFToolStripMenuItem";
            this.wCFToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.wCFToolStripMenuItem.Text = "WCF";
            // 
            // serviceHostingToolStripMenuItem
            // 
            this.serviceHostingToolStripMenuItem.Name = "serviceHostingToolStripMenuItem";
            this.serviceHostingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.serviceHostingToolStripMenuItem.Text = "Service Hosting";
            this.serviceHostingToolStripMenuItem.Click += new System.EventHandler(this.ServiceHostingToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // loadTestClientToolStripMenuItem
            // 
            this.loadTestClientToolStripMenuItem.Name = "loadTestClientToolStripMenuItem";
            this.loadTestClientToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loadTestClientToolStripMenuItem.Text = "Load Test Client";
            this.loadTestClientToolStripMenuItem.Click += new System.EventHandler(this.LoadTestClientToolStripMenuItem_Click);
            // 
            // singleTestClientToolStripMenuItem
            // 
            this.singleTestClientToolStripMenuItem.Name = "singleTestClientToolStripMenuItem";
            this.singleTestClientToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.singleTestClientToolStripMenuItem.Text = "Single Test Client";
            this.singleTestClientToolStripMenuItem.Click += new System.EventHandler(this.SingleTestClientToolStripMenuItem_Click);
            // 
            // secureClientToolStripMenuItem
            // 
            this.secureClientToolStripMenuItem.Name = "secureClientToolStripMenuItem";
            this.secureClientToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.secureClientToolStripMenuItem.Text = "Secure Client";
            this.secureClientToolStripMenuItem.Click += new System.EventHandler(this.SecureClientToolStripMenuItem_Click);
            // 
            // proxyProblemToolStripMenuItem
            // 
            this.proxyProblemToolStripMenuItem.Name = "proxyProblemToolStripMenuItem";
            this.proxyProblemToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.proxyProblemToolStripMenuItem.Text = "Proxy Problem";
            this.proxyProblemToolStripMenuItem.Click += new System.EventHandler(this.ProxyProblemToolStripMenuItem_Click);
            // 
            // gCNotificationToolStripMenuItem
            // 
            this.gCNotificationToolStripMenuItem.Name = "gCNotificationToolStripMenuItem";
            this.gCNotificationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gCNotificationToolStripMenuItem.Text = "GC Notification";
            this.gCNotificationToolStripMenuItem.Click += new System.EventHandler(this.gCNotificationToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 159);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuggerNET";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constantCPUUsageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longListAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threadUnsafeGDAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTCPServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToTCPServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longServiceResponseTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wAITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tooLowRequestssecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unresponsiveUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCEPTIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileBeingUsedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wCFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceHostingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadTestClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secureClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleTestClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benchmarkDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gCNotificationToolStripMenuItem;
    }
}

