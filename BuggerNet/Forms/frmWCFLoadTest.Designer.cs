namespace BuggerNet
{
    partial class frmWCFLoadTest
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
            this.m_cbReuseProxy = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHostTimeThreads = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHostNameThreads = new System.Windows.Forms.TextBox();
            this.gbCreateLoad = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDelayThreads = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCounterThreads = new System.Windows.Forms.TextBox();
            this.tbIncrementThreads = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDecrementThreads = new System.Windows.Forms.TextBox();
            this.tbPingThreads = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.cBoxClientList = new System.Windows.Forms.ComboBox();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.rbOutput = new System.Windows.Forms.RichTextBox();
            this.gbCreateLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cbReuseProxy
            // 
            this.m_cbReuseProxy.AutoSize = true;
            this.m_cbReuseProxy.Location = new System.Drawing.Point(13, 243);
            this.m_cbReuseProxy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.m_cbReuseProxy.Name = "m_cbReuseProxy";
            this.m_cbReuseProxy.Size = new System.Drawing.Size(156, 17);
            this.m_cbReuseProxy.TabIndex = 23;
            this.m_cbReuseProxy.Text = "Reuse proxy in each thread";
            this.m_cbReuseProxy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Call Ping on ";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(127, 271);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 25);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 271);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 25);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "threads";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "threads";
            // 
            // tbHostTimeThreads
            // 
            this.tbHostTimeThreads.Location = new System.Drawing.Point(113, 83);
            this.tbHostTimeThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbHostTimeThreads.Name = "tbHostTimeThreads";
            this.tbHostTimeThreads.Size = new System.Drawing.Size(76, 20);
            this.tbHostTimeThreads.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Call HostTime on ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "threads";
            // 
            // tbHostNameThreads
            // 
            this.tbHostNameThreads.Location = new System.Drawing.Point(113, 53);
            this.tbHostNameThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbHostNameThreads.Name = "tbHostNameThreads";
            this.tbHostNameThreads.Size = new System.Drawing.Size(76, 20);
            this.tbHostNameThreads.TabIndex = 16;
            // 
            // gbCreateLoad
            // 
            this.gbCreateLoad.Controls.Add(this.label15);
            this.gbCreateLoad.Controls.Add(this.tbDuration);
            this.gbCreateLoad.Controls.Add(this.label3);
            this.gbCreateLoad.Controls.Add(this.tbDelayThreads);
            this.gbCreateLoad.Controls.Add(this.label4);
            this.gbCreateLoad.Controls.Add(this.label9);
            this.gbCreateLoad.Controls.Add(this.label10);
            this.gbCreateLoad.Controls.Add(this.tbCounterThreads);
            this.gbCreateLoad.Controls.Add(this.tbIncrementThreads);
            this.gbCreateLoad.Controls.Add(this.label11);
            this.gbCreateLoad.Controls.Add(this.label12);
            this.gbCreateLoad.Controls.Add(this.label13);
            this.gbCreateLoad.Controls.Add(this.label14);
            this.gbCreateLoad.Controls.Add(this.tbDecrementThreads);
            this.gbCreateLoad.Controls.Add(this.m_cbReuseProxy);
            this.gbCreateLoad.Controls.Add(this.label1);
            this.gbCreateLoad.Controls.Add(this.btnStop);
            this.gbCreateLoad.Controls.Add(this.tbPingThreads);
            this.gbCreateLoad.Controls.Add(this.btnStart);
            this.gbCreateLoad.Controls.Add(this.label2);
            this.gbCreateLoad.Controls.Add(this.label7);
            this.gbCreateLoad.Controls.Add(this.tbHostTimeThreads);
            this.gbCreateLoad.Controls.Add(this.label8);
            this.gbCreateLoad.Controls.Add(this.label5);
            this.gbCreateLoad.Controls.Add(this.label6);
            this.gbCreateLoad.Controls.Add(this.tbHostNameThreads);
            this.gbCreateLoad.Location = new System.Drawing.Point(16, 62);
            this.gbCreateLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbCreateLoad.Name = "gbCreateLoad";
            this.gbCreateLoad.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbCreateLoad.Size = new System.Drawing.Size(246, 311);
            this.gbCreateLoad.TabIndex = 27;
            this.gbCreateLoad.TabStop = false;
            this.gbCreateLoad.Text = "Create Load";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 221);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Duration (msec)";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(115, 221);
            this.tbDuration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(76, 20);
            this.tbDuration.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "threads";
            // 
            // tbDelayThreads
            // 
            this.tbDelayThreads.Location = new System.Drawing.Point(115, 196);
            this.tbDelayThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDelayThreads.Name = "tbDelayThreads";
            this.tbDelayThreads.Size = new System.Drawing.Size(76, 20);
            this.tbDelayThreads.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Call Delay on ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "threads";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Call Increment on ";
            // 
            // tbCounterThreads
            // 
            this.tbCounterThreads.Location = new System.Drawing.Point(115, 170);
            this.tbCounterThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCounterThreads.Name = "tbCounterThreads";
            this.tbCounterThreads.Size = new System.Drawing.Size(76, 20);
            this.tbCounterThreads.TabIndex = 31;
            // 
            // tbIncrementThreads
            // 
            this.tbIncrementThreads.Location = new System.Drawing.Point(115, 112);
            this.tbIncrementThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIncrementThreads.Name = "tbIncrementThreads";
            this.tbIncrementThreads.Size = new System.Drawing.Size(76, 20);
            this.tbIncrementThreads.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Call GetCounter on ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "threads";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "threads";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 142);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Call Decrement on ";
            // 
            // tbDecrementThreads
            // 
            this.tbDecrementThreads.Location = new System.Drawing.Point(115, 142);
            this.tbDecrementThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDecrementThreads.Name = "tbDecrementThreads";
            this.tbDecrementThreads.Size = new System.Drawing.Size(76, 20);
            this.tbDecrementThreads.TabIndex = 28;
            // 
            // tbPingThreads
            // 
            this.tbPingThreads.Location = new System.Drawing.Point(113, 25);
            this.tbPingThreads.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPingThreads.Name = "tbPingThreads";
            this.tbPingThreads.Size = new System.Drawing.Size(76, 20);
            this.tbPingThreads.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Call HostName on ";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(13, 16);
            this.lblServiceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(83, 13);
            this.lblServiceName.TabIndex = 30;
            this.lblServiceName.Text = "Service Name : ";
            // 
            // cBoxClientList
            // 
            this.cBoxClientList.FormattingEnabled = true;
            this.cBoxClientList.Location = new System.Drawing.Point(16, 39);
            this.cBoxClientList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cBoxClientList.Name = "cBoxClientList";
            this.cBoxClientList.Size = new System.Drawing.Size(239, 21);
            this.cBoxClientList.TabIndex = 29;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(289, 354);
            this.btnClearOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(217, 21);
            this.btnClearOutput.TabIndex = 31;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // rbOutput
            // 
            this.rbOutput.Location = new System.Drawing.Point(289, 39);
            this.rbOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rbOutput.Name = "rbOutput";
            this.rbOutput.Size = new System.Drawing.Size(226, 304);
            this.rbOutput.TabIndex = 32;
            this.rbOutput.Text = "";
            // 
            // frmWCFLoadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 393);
            this.Controls.Add(this.rbOutput);
            this.Controls.Add(this.btnClearOutput);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.cBoxClientList);
            this.Controls.Add(this.gbCreateLoad);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmWCFLoadTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Test";
            this.gbCreateLoad.ResumeLayout(false);
            this.gbCreateLoad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox m_cbReuseProxy;
        private System.Windows.Forms.Label label1;        
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbHostTimeThreads;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbHostNameThreads;
        private System.Windows.Forms.GroupBox gbCreateLoad;
        private System.Windows.Forms.TextBox tbPingThreads;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCounterThreads;
        private System.Windows.Forms.TextBox tbIncrementThreads;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDecrementThreads;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.ComboBox cBoxClientList;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDelayThreads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rbOutput;
        //public static System.Windows.Forms.RichTextBox rbOutput;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDuration;
    }
}