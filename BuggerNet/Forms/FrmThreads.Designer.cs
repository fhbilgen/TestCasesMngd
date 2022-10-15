namespace BuggerNet.Forms
{
    partial class FrmThreads
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
            this.gbThread = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblThName = new System.Windows.Forms.Label();
            this.rbForeground = new System.Windows.Forms.RadioButton();
            this.rbBackground = new System.Windows.Forms.RadioButton();
            this.btnStartTh = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.lvOutput = new System.Windows.Forms.ListView();
            this.lvThreads = new System.Windows.Forms.ListView();
            this.tmrThInfo = new System.Windows.Forms.Timer(this.components);
            this.gbThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThread
            // 
            this.gbThread.Controls.Add(this.tbName);
            this.gbThread.Controls.Add(this.lblThName);
            this.gbThread.Controls.Add(this.rbForeground);
            this.gbThread.Controls.Add(this.rbBackground);
            this.gbThread.Location = new System.Drawing.Point(12, 12);
            this.gbThread.Name = "gbThread";
            this.gbThread.Size = new System.Drawing.Size(396, 57);
            this.gbThread.TabIndex = 0;
            this.gbThread.TabStop = false;
            this.gbThread.Text = "Thread";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(297, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(85, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblThName
            // 
            this.lblThName.AutoSize = true;
            this.lblThName.Location = new System.Drawing.Point(206, 26);
            this.lblThName.Name = "lblThName";
            this.lblThName.Size = new System.Drawing.Size(76, 13);
            this.lblThName.TabIndex = 2;
            this.lblThName.Text = "Thread name: ";
            // 
            // rbForeground
            // 
            this.rbForeground.AutoSize = true;
            this.rbForeground.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbForeground.Checked = true;
            this.rbForeground.Location = new System.Drawing.Point(10, 23);
            this.rbForeground.Name = "rbForeground";
            this.rbForeground.Size = new System.Drawing.Size(79, 17);
            this.rbForeground.TabIndex = 1;
            this.rbForeground.TabStop = true;
            this.rbForeground.Text = "Foreground";
            this.rbForeground.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbForeground.UseVisualStyleBackColor = true;
            // 
            // rbBackground
            // 
            this.rbBackground.AutoSize = true;
            this.rbBackground.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBackground.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbBackground.Location = new System.Drawing.Point(101, 23);
            this.rbBackground.Name = "rbBackground";
            this.rbBackground.Size = new System.Drawing.Size(83, 17);
            this.rbBackground.TabIndex = 0;
            this.rbBackground.Text = "Background";
            this.rbBackground.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBackground.UseVisualStyleBackColor = true;
            // 
            // btnStartTh
            // 
            this.btnStartTh.Location = new System.Drawing.Point(743, 35);
            this.btnStartTh.Name = "btnStartTh";
            this.btnStartTh.Size = new System.Drawing.Size(102, 23);
            this.btnStartTh.TabIndex = 1;
            this.btnStartTh.Text = "Start Thread";
            this.btnStartTh.UseVisualStyleBackColor = true;
            this.btnStartTh.Click += new System.EventHandler(this.BtnStartTh_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(864, 35);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(102, 23);
            this.btnExitApp.TabIndex = 2;
            this.btnExitApp.Text = "Exit Application";
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // lvOutput
            // 
            this.lvOutput.HideSelection = false;
            this.lvOutput.Location = new System.Drawing.Point(13, 75);
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size(201, 319);
            this.lvOutput.TabIndex = 3;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.Details;
            // 
            // lvThreads
            // 
            this.lvThreads.HideSelection = false;
            this.lvThreads.Location = new System.Drawing.Point(226, 75);
            this.lvThreads.Name = "lvThreads";
            this.lvThreads.Size = new System.Drawing.Size(740, 319);
            this.lvThreads.TabIndex = 4;
            this.lvThreads.UseCompatibleStateImageBehavior = false;
            this.lvThreads.View = System.Windows.Forms.View.Details;
            // 
            // tmrThInfo
            // 
            this.tmrThInfo.Interval = 2000;
            this.tmrThInfo.Tick += new System.EventHandler(this.TmrThInfo_Tick);
            // 
            // FrmThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 406);
            this.Controls.Add(this.lvThreads);
            this.Controls.Add(this.lvOutput);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnStartTh);
            this.Controls.Add(this.gbThread);
            this.Name = "FrmThreads";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Threads";
            this.gbThread.ResumeLayout(false);
            this.gbThread.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThread;
        private System.Windows.Forms.RadioButton rbBackground;
        private System.Windows.Forms.RadioButton rbForeground;
        private System.Windows.Forms.Button btnStartTh;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblThName;
        private System.Windows.Forms.ListView lvThreads;
        private System.Windows.Forms.Timer tmrThInfo;
    }
}