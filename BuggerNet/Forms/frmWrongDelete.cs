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
    public partial class frmWrongDelete : Form
    {

        List<string> m_strList = null;
        public frmWrongDelete()
        {
            InitializeComponent();
        }


        private void UpdateResult(string strText)
        {
            rtbResult.AppendText(strText + "\n\r");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int count = 0;
            DateTime dtStart, dtStop;
            string strOutput;

            if (m_strList == null)
            {
                m_strList = new List<string>();
            }
            else
            {
                m_strList.Clear();
                m_strList = null;
                m_strList = new List<string>();
            }

            if (!string.IsNullOrEmpty(tbCount.Text))
                Int32.TryParse(tbCount.Text, out count);
            else
                count = 0;

            Application.UseWaitCursor = true;

            dtStart = DateTime.Now;
            
            for (int i = 0; i != count; i++)
                m_strList.Add("0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");

            dtStop = DateTime.Now;

            Application.UseWaitCursor = false;

            strOutput = "Insertion time : "+ dtStart.ToLongTimeString() + " - " + dtStop.ToLongTimeString();
            UpdateResult(strOutput);

        }

        private void btnBadRemove_Click(object sender, EventArgs e)
        {
            int count = 0;
            DateTime dtStart, dtStop;
            string strOutput;
            
            if (!string.IsNullOrEmpty(tbCount.Text))
                Int32.TryParse(tbCount.Text, out count);
            else
                count = 0;

            if (m_strList.Count == 0)
            {
                MessageBox.Show("The list is empty", "Managed Tests", MessageBoxButtons.OK);
                return;
            }

            Application.UseWaitCursor = true;

            dtStart = DateTime.Now;
                        
            for (int i = 0; i != count; i++)
                m_strList.RemoveAt(0);

            dtStop = DateTime.Now;
            Application.UseWaitCursor = false;

            strOutput = "Deletion from top (" + count.ToString()+ "): " + dtStart.ToLongTimeString() + " - " + dtStop.ToLongTimeString();
            UpdateResult(strOutput);
        }

        private void btnRemoveButtom_Click(object sender, EventArgs e)
        {
            int count = 0;
            DateTime dtStart, dtStop;
            string strOutput;

            if (!string.IsNullOrEmpty(tbCount.Text))
                Int32.TryParse(tbCount.Text, out count);
            else
                count = 0;

            if (m_strList.Count == 0)
            {
                MessageBox.Show("The list is empty", "Managed Tests", MessageBoxButtons.OK);
                return;
            }

            Application.UseWaitCursor = true;

            dtStart = DateTime.Now;

            for (int i = 0; i != count; i++)
                m_strList.RemoveAt( m_strList.Count-1 );

            dtStop = DateTime.Now;

            Application.UseWaitCursor = false;

            strOutput = "Deletion from bottom (" + count.ToString() + "): " + dtStart.ToLongTimeString() + " - " + dtStop.ToLongTimeString();
            UpdateResult(strOutput);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbResult.Clear();
        }
    }
}
