using BuggerNetEng.Engine;
using BuggerNetEng.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuggerNet.Forms
{
    public partial class FrmCreateObj : Form
    {
        public FrmCreateObj()
        {
            InitializeComponent();
        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        private void BtnCrtObj_Click(object sender, EventArgs e)
        {
            MemEng.NewObject();
            MessageBox.Show("Object created!");
        }
    }
}
