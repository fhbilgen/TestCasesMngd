using System.Threading;

namespace BuggerNet.Forms
{
    partial class FrmMemGCNotification
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
            this.components = new System.ComponentModel.Container();
            this.btnGCNtfStart = new System.Windows.Forms.Button();
            this.btnGCNtfStop = new System.Windows.Forms.Button();
            this.lvGCEvents = new System.Windows.Forms.ListView();
            this.lblAllocMem = new System.Windows.Forms.Label();
            this.tbAllocMem = new System.Windows.Forms.TextBox();
            this.lblMemDelta = new System.Windows.Forms.Label();
            this.tbMemDelta = new System.Windows.Forms.TextBox();
            this.lblPlFreq = new System.Windows.Forms.Label();
            this.tbPlFreq = new System.Windows.Forms.TextBox();
            this.lblGen2Th = new System.Windows.Forms.Label();
            this.tcbGen2 = new System.Windows.Forms.TrackBar();
            this.lblLOHTh = new System.Windows.Forms.Label();
            this.tcbLOHTh = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvPC = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPCFreq = new System.Windows.Forms.TextBox();
            this.tmrPCRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tcbGen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbLOHTh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGCNtfStart
            // 
            this.btnGCNtfStart.Location = new System.Drawing.Point(95, 195);
            this.btnGCNtfStart.Name = "btnGCNtfStart";
            this.btnGCNtfStart.Size = new System.Drawing.Size(75, 23);
            this.btnGCNtfStart.TabIndex = 0;
            this.btnGCNtfStart.Text = "Start";
            this.btnGCNtfStart.UseVisualStyleBackColor = true;
            this.btnGCNtfStart.Click += new System.EventHandler(this.BtnGCNtfStart_Click);
            // 
            // btnGCNtfStop
            // 
            this.btnGCNtfStop.Location = new System.Drawing.Point(197, 195);
            this.btnGCNtfStop.Name = "btnGCNtfStop";
            this.btnGCNtfStop.Size = new System.Drawing.Size(75, 23);
            this.btnGCNtfStop.TabIndex = 1;
            this.btnGCNtfStop.Text = "Stop";
            this.btnGCNtfStop.UseVisualStyleBackColor = true;
            this.btnGCNtfStop.Click += new System.EventHandler(this.BtnGCNtfStop_Click);
            // 
            // lvGCEvents
            // 
            this.lvGCEvents.HideSelection = false;
            this.lvGCEvents.Location = new System.Drawing.Point(314, 41);
            this.lvGCEvents.Name = "lvGCEvents";
            this.lvGCEvents.Size = new System.Drawing.Size(215, 571);
            this.lvGCEvents.TabIndex = 2;
            this.lvGCEvents.UseCompatibleStateImageBehavior = false;
            this.lvGCEvents.View = System.Windows.Forms.View.Details;
            // 
            // lblAllocMem
            // 
            this.lblAllocMem.AutoSize = true;
            this.lblAllocMem.Location = new System.Drawing.Point(314, 19);
            this.lblAllocMem.Name = "lblAllocMem";
            this.lblAllocMem.Size = new System.Drawing.Size(125, 13);
            this.lblAllocMem.TabIndex = 3;
            this.lblAllocMem.Text = "Allocated Memory (MB) : ";
            // 
            // tbAllocMem
            // 
            this.tbAllocMem.Location = new System.Drawing.Point(443, 16);
            this.tbAllocMem.Name = "tbAllocMem";
            this.tbAllocMem.ReadOnly = true;
            this.tbAllocMem.Size = new System.Drawing.Size(86, 20);
            this.tbAllocMem.TabIndex = 4;
            // 
            // lblMemDelta
            // 
            this.lblMemDelta.AutoSize = true;
            this.lblMemDelta.Location = new System.Drawing.Point(8, 21);
            this.lblMemDelta.Name = "lblMemDelta";
            this.lblMemDelta.Size = new System.Drawing.Size(108, 13);
            this.lblMemDelta.TabIndex = 5;
            this.lblMemDelta.Text = "Allocation Size (KB) : ";
            // 
            // tbMemDelta
            // 
            this.tbMemDelta.Location = new System.Drawing.Point(125, 18);
            this.tbMemDelta.Name = "tbMemDelta";
            this.tbMemDelta.Size = new System.Drawing.Size(77, 20);
            this.tbMemDelta.TabIndex = 6;
            this.tbMemDelta.Text = "1";
            // 
            // lblPlFreq
            // 
            this.lblPlFreq.AutoSize = true;
            this.lblPlFreq.Location = new System.Drawing.Point(8, 49);
            this.lblPlFreq.Name = "lblPlFreq";
            this.lblPlFreq.Size = new System.Drawing.Size(118, 13);
            this.lblPlFreq.TabIndex = 7;
            this.lblPlFreq.Text = "Polling interval (msec) : ";
            // 
            // tbPlFreq
            // 
            this.tbPlFreq.Location = new System.Drawing.Point(125, 46);
            this.tbPlFreq.Name = "tbPlFreq";
            this.tbPlFreq.Size = new System.Drawing.Size(77, 20);
            this.tbPlFreq.TabIndex = 8;
            this.tbPlFreq.Text = "1000";
            // 
            // lblGen2Th
            // 
            this.lblGen2Th.AutoSize = true;
            this.lblGen2Th.Location = new System.Drawing.Point(8, 116);
            this.lblGen2Th.Name = "lblGen2Th";
            this.lblGen2Th.Size = new System.Drawing.Size(95, 13);
            this.lblGen2Th.TabIndex = 9;
            this.lblGen2Th.Text = "Gen 2 Threshold : ";
            // 
            // tcbGen2
            // 
            this.tcbGen2.Location = new System.Drawing.Point(125, 103);
            this.tcbGen2.Maximum = 100;
            this.tcbGen2.Name = "tcbGen2";
            this.tcbGen2.Size = new System.Drawing.Size(156, 45);
            this.tcbGen2.TabIndex = 10;
            this.tcbGen2.TickFrequency = 5;
            this.tcbGen2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tcbGen2.Value = 25;
            // 
            // lblLOHTh
            // 
            this.lblLOHTh.AutoSize = true;
            this.lblLOHTh.Location = new System.Drawing.Point(8, 156);
            this.lblLOHTh.Name = "lblLOHTh";
            this.lblLOHTh.Size = new System.Drawing.Size(88, 13);
            this.lblLOHTh.TabIndex = 11;
            this.lblLOHTh.Text = "LOH Threshold : ";
            // 
            // tcbLOHTh
            // 
            this.tcbLOHTh.Location = new System.Drawing.Point(125, 146);
            this.tcbLOHTh.Maximum = 100;
            this.tcbLOHTh.Name = "tcbLOHTh";
            this.tcbLOHTh.Size = new System.Drawing.Size(156, 45);
            this.tcbLOHTh.TabIndex = 12;
            this.tcbLOHTh.TickFrequency = 5;
            this.tcbLOHTh.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tcbLOHTh.Value = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPCFreq);
            this.groupBox1.Controls.Add(this.lblMemDelta);
            this.groupBox1.Controls.Add(this.tcbLOHTh);
            this.groupBox1.Controls.Add(this.tbMemDelta);
            this.groupBox1.Controls.Add(this.lblLOHTh);
            this.groupBox1.Controls.Add(this.lblPlFreq);
            this.groupBox1.Controls.Add(this.btnGCNtfStop);
            this.groupBox1.Controls.Add(this.tcbGen2);
            this.groupBox1.Controls.Add(this.btnGCNtfStart);
            this.groupBox1.Controls.Add(this.tbPlFreq);
            this.groupBox1.Controls.Add(this.lblGen2Th);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 231);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lvPC
            // 
            this.lvPC.HideSelection = false;
            this.lvPC.Location = new System.Drawing.Point(12, 258);
            this.lvPC.Name = "lvPC";
            this.lvPC.Size = new System.Drawing.Size(287, 354);
            this.lvPC.TabIndex = 14;
            this.lvPC.UseCompatibleStateImageBehavior = false;
            this.lvPC.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Counter refresh (sec) : ";
            // 
            // tbPCFreq
            // 
            this.tbPCFreq.Location = new System.Drawing.Point(125, 74);
            this.tbPCFreq.Name = "tbPCFreq";
            this.tbPCFreq.Size = new System.Drawing.Size(77, 20);
            this.tbPCFreq.TabIndex = 14;
            this.tbPCFreq.Text = "1";
            // 
            // tmrPCRefresh
            // 
            this.tmrPCRefresh.Enabled = false;
            this.tmrPCRefresh.Tick += new System.EventHandler(this.TmrPCRefresh_Tick);
            // 
            // FrmMemGCNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 624);
            this.Controls.Add(this.lvPC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAllocMem);
            this.Controls.Add(this.lblAllocMem);
            this.Controls.Add(this.lvGCEvents);
            this.Name = "FrmMemGCNotification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GC Notification";
            ((System.ComponentModel.ISupportInitialize)(this.tcbGen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcbLOHTh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGCNtfStart;
        private System.Windows.Forms.Button btnGCNtfStop;
        private System.Windows.Forms.ListView lvGCEvents;
        private System.Windows.Forms.Label lblAllocMem;
        private System.Windows.Forms.TextBox tbAllocMem;
        private System.Windows.Forms.Label lblMemDelta;
        private System.Windows.Forms.TextBox tbMemDelta;
        private System.Windows.Forms.Label lblPlFreq;
        private System.Windows.Forms.TextBox tbPlFreq;
        private System.Windows.Forms.Label lblGen2Th;
        private System.Windows.Forms.TrackBar tcbGen2;
        private System.Windows.Forms.Label lblLOHTh;
        private System.Windows.Forms.TrackBar tcbLOHTh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPCFreq;
        private System.Windows.Forms.Timer tmrPCRefresh;
    }
}