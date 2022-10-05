namespace BuggerNet.Forms
{
    partial class FrmCreateObj
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
            this.btnCrtObj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrtObj
            // 
            this.btnCrtObj.Location = new System.Drawing.Point(81, 42);
            this.btnCrtObj.Name = "btnCrtObj";
            this.btnCrtObj.Size = new System.Drawing.Size(75, 23);
            this.btnCrtObj.TabIndex = 0;
            this.btnCrtObj.Text = "Create Object!";
            this.btnCrtObj.UseVisualStyleBackColor = true;
            this.btnCrtObj.Click += new System.EventHandler(this.BtnCrtObj_Click);
            // 
            // frmCreateObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 106);
            this.Controls.Add(this.btnCrtObj);
            this.Name = "frmCreateObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create an Object";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrtObj;
    }
}