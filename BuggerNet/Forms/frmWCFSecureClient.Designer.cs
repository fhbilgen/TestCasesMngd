namespace BuggerNet
{
    partial class frmWCFSecureClient
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
            this.gbMethodInvocation = new System.Windows.Forms.GroupBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.tbPing = new System.Windows.Forms.TextBox();
            this.btnEcho = new System.Windows.Forms.Button();
            this.tbEcho = new System.Windows.Forms.TextBox();
            this.btnGetHostName = new System.Windows.Forms.Button();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.btnGetHostTime = new System.Windows.Forms.Button();
            this.tbHostTime = new System.Windows.Forms.TextBox();
            this.gbMethodInvocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMethodInvocation
            // 
            this.gbMethodInvocation.Controls.Add(this.btnPing);
            this.gbMethodInvocation.Controls.Add(this.tbPing);
            this.gbMethodInvocation.Controls.Add(this.btnEcho);
            this.gbMethodInvocation.Controls.Add(this.tbEcho);
            this.gbMethodInvocation.Controls.Add(this.btnGetHostName);
            this.gbMethodInvocation.Controls.Add(this.tbHostName);
            this.gbMethodInvocation.Controls.Add(this.btnGetHostTime);
            this.gbMethodInvocation.Controls.Add(this.tbHostTime);
            this.gbMethodInvocation.Location = new System.Drawing.Point(13, 10);
            this.gbMethodInvocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMethodInvocation.Name = "gbMethodInvocation";
            this.gbMethodInvocation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMethodInvocation.Size = new System.Drawing.Size(310, 197);
            this.gbMethodInvocation.TabIndex = 26;
            this.gbMethodInvocation.TabStop = false;
            this.gbMethodInvocation.Text = "Method Calls";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(4, 25);
            this.btnPing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(106, 25);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // tbPing
            // 
            this.tbPing.Location = new System.Drawing.Point(122, 25);
            this.tbPing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPing.Name = "tbPing";
            this.tbPing.Size = new System.Drawing.Size(176, 20);
            this.tbPing.TabIndex = 7;
            // 
            // btnEcho
            // 
            this.btnEcho.Location = new System.Drawing.Point(4, 64);
            this.btnEcho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEcho.Name = "btnEcho";
            this.btnEcho.Size = new System.Drawing.Size(106, 25);
            this.btnEcho.TabIndex = 1;
            this.btnEcho.Text = "Echo";
            this.btnEcho.UseVisualStyleBackColor = true;
            this.btnEcho.Click += new System.EventHandler(this.btnEcho_Click);
            // 
            // tbEcho
            // 
            this.tbEcho.Location = new System.Drawing.Point(122, 64);
            this.tbEcho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEcho.Name = "tbEcho";
            this.tbEcho.Size = new System.Drawing.Size(176, 20);
            this.tbEcho.TabIndex = 6;
            // 
            // btnGetHostName
            // 
            this.btnGetHostName.Location = new System.Drawing.Point(4, 103);
            this.btnGetHostName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetHostName.Name = "btnGetHostName";
            this.btnGetHostName.Size = new System.Drawing.Size(106, 25);
            this.btnGetHostName.TabIndex = 2;
            this.btnGetHostName.Text = "Get Host Name";
            this.btnGetHostName.UseVisualStyleBackColor = true;
            this.btnGetHostName.Click += new System.EventHandler(this.btnGetHostName_Click);
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(122, 103);
            this.tbHostName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(176, 20);
            this.tbHostName.TabIndex = 5;
            // 
            // btnGetHostTime
            // 
            this.btnGetHostTime.Location = new System.Drawing.Point(4, 142);
            this.btnGetHostTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetHostTime.Name = "btnGetHostTime";
            this.btnGetHostTime.Size = new System.Drawing.Size(106, 25);
            this.btnGetHostTime.TabIndex = 3;
            this.btnGetHostTime.Text = "Get Host Time";
            this.btnGetHostTime.UseVisualStyleBackColor = true;
            this.btnGetHostTime.Click += new System.EventHandler(this.btnGetHostTime_Click);
            // 
            // tbHostTime
            // 
            this.tbHostTime.Location = new System.Drawing.Point(122, 142);
            this.tbHostTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHostTime.Name = "tbHostTime";
            this.tbHostTime.Size = new System.Drawing.Size(176, 20);
            this.tbHostTime.TabIndex = 4;
            // 
            // frmWCFSecureClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 259);
            this.Controls.Add(this.gbMethodInvocation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWCFSecureClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Secure Client Test";
            this.gbMethodInvocation.ResumeLayout(false);
            this.gbMethodInvocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMethodInvocation;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox tbPing;
        private System.Windows.Forms.Button btnEcho;
        private System.Windows.Forms.TextBox tbEcho;
        private System.Windows.Forms.Button btnGetHostName;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.Button btnGetHostTime;
        private System.Windows.Forms.TextBox tbHostTime;
    }
}