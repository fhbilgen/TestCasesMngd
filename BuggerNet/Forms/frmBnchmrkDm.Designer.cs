namespace BuggerNet.Forms
{
    partial class frmBnchmrkDm
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
            this.gbBnDm = new System.Windows.Forms.GroupBox();
            this.lblBnDmArrCnt = new System.Windows.Forms.Label();
            this.tbArrLen = new System.Windows.Forms.TextBox();
            this.btnBnDmTest = new System.Windows.Forms.Button();
            this.gbBnDm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBnDm
            // 
            this.gbBnDm.Controls.Add(this.tbArrLen);
            this.gbBnDm.Controls.Add(this.lblBnDmArrCnt);
            this.gbBnDm.Location = new System.Drawing.Point(12, 12);
            this.gbBnDm.Name = "gbBnDm";
            this.gbBnDm.Size = new System.Drawing.Size(205, 57);
            this.gbBnDm.TabIndex = 0;
            this.gbBnDm.TabStop = false;
            // 
            // lblBnDmArrCnt
            // 
            this.lblBnDmArrCnt.AutoSize = true;
            this.lblBnDmArrCnt.Location = new System.Drawing.Point(7, 20);
            this.lblBnDmArrCnt.Name = "lblBnDmArrCnt";
            this.lblBnDmArrCnt.Size = new System.Drawing.Size(76, 13);
            this.lblBnDmArrCnt.TabIndex = 0;
            this.lblBnDmArrCnt.Text = "Array Length : ";
            // 
            // tbArrLen
            // 
            this.tbArrLen.Location = new System.Drawing.Point(90, 20);
            this.tbArrLen.Name = "tbArrLen";
            this.tbArrLen.Size = new System.Drawing.Size(100, 20);
            this.tbArrLen.TabIndex = 1;
            // 
            // btnBnDmTest
            // 
            this.btnBnDmTest.Location = new System.Drawing.Point(82, 85);
            this.btnBnDmTest.Name = "btnBnDmTest";
            this.btnBnDmTest.Size = new System.Drawing.Size(75, 23);
            this.btnBnDmTest.TabIndex = 2;
            this.btnBnDmTest.Text = "Test";
            this.btnBnDmTest.UseVisualStyleBackColor = true;
            this.btnBnDmTest.Click += new System.EventHandler(this.btnBnDmTest_Click);
            // 
            // frmBnchmrkDm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 125);
            this.Controls.Add(this.btnBnDmTest);
            this.Controls.Add(this.gbBnDm);
            this.Name = "frmBnchmrkDm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Benchmark Demo";
            this.gbBnDm.ResumeLayout(false);
            this.gbBnDm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBnDm;
        private System.Windows.Forms.TextBox tbArrLen;
        private System.Windows.Forms.Label lblBnDmArrCnt;
        private System.Windows.Forms.Button btnBnDmTest;
    }
}