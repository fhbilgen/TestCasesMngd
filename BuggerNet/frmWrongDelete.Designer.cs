namespace BuggerNet
{
    partial class frmWrongDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBadRemove = new System.Windows.Forms.Button();
            this.btnRemoveButtom = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of objects to be inserted:";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(201, 24);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(121, 20);
            this.tbCount.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(435, 58);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBadRemove
            // 
            this.btnBadRemove.Location = new System.Drawing.Point(435, 96);
            this.btnBadRemove.Name = "btnBadRemove";
            this.btnBadRemove.Size = new System.Drawing.Size(121, 23);
            this.btnBadRemove.TabIndex = 4;
            this.btnBadRemove.Text = "Remove from top";
            this.btnBadRemove.UseVisualStyleBackColor = true;
            this.btnBadRemove.Click += new System.EventHandler(this.btnBadRemove_Click);
            // 
            // btnRemoveButtom
            // 
            this.btnRemoveButtom.Location = new System.Drawing.Point(435, 134);
            this.btnRemoveButtom.Name = "btnRemoveButtom";
            this.btnRemoveButtom.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveButtom.TabIndex = 5;
            this.btnRemoveButtom.Text = "Remove from bottom";
            this.btnRemoveButtom.UseVisualStyleBackColor = true;
            this.btnRemoveButtom.Click += new System.EventHandler(this.btnRemoveButtom_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(24, 58);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(381, 191);
            this.rtbResult.TabIndex = 6;
            this.rtbResult.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmWrongDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnRemoveButtom);
            this.Controls.Add(this.btnBadRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label1);
            this.Name = "frmWrongDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWrongDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBadRemove;
        private System.Windows.Forms.Button btnRemoveButtom;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btnClear;
    }
}