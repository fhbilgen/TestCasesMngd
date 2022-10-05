using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Configuration;
using BuggerNetEng.Engine;

namespace BuggerNet
{
    public partial class frmFSConstructor : Form
    {
        public frmFSConstructor()
        {
            InitializeComponent();
            tbFileName.Text = "NobelPhysicsLaureates.xml";
            tbDuration.Text = "10000";
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            int sleepDuration;
            string strFileName;
            Configuration configManager = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            KeyValueConfigurationCollection confCollection = configManager.AppSettings.Settings;

            strFileName = confCollection["NobelPhysicsLaureates"].Value.ToString();

            if (!string.IsNullOrEmpty(tbDuration.Text))
                Int32.TryParse(tbDuration.Text, out sleepDuration);
            else
                sleepDuration = 0;

            NobelPhysicsLaureateList listNPL = new NobelPhysicsLaureateList();

            using (FileStream fs = new FileStream(strFileName, FileMode.Open))
            {
                using (TextReader tr = new StreamReader(fs))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(NobelPhysicsLaureateList));
                    listNPL = (NobelPhysicsLaureateList)serializer.Deserialize(tr);

                    foreach (NobelPhysicsLaureate nbl in listNPL.NPLList)
                        rtbNPL.AppendText(string.Format("{0}\t{1}\t{2}\t{3}\n", nbl.ID, nbl.Name, nbl.Surname, nbl.City));


                    Thread.Sleep(sleepDuration);

                    MessageBox.Show("DONE!");
                }
            }            
        }

    }
}
