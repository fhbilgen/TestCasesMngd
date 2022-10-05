using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenchmarkDotNet.Running;
using BuggerNetEng.Engine;

namespace BuggerNet.Forms
{
    public partial class frmBnchmrkDm : Form
    {
        public frmBnchmrkDm()
        {
            InitializeComponent();
        }

        private void btnBnDmTest_Click(object sender, EventArgs e)
        {
            //int.TryParse(tbArrLen.Text, out int len);
            var summary = BenchmarkRunner.Run < BenchmarkDemo > ();
        }
    }
}
