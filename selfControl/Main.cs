using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace selfControl
{
    public partial class Main : Form
    {  

        public Main()
        {
            InitializeComponent();
        }
       
    

        private void serialMonitor_Click(object sender, EventArgs e)
        {

            UI.monitorVariable frm = new UI.monitorVariable();
            frm.TopLevel = false;
            frm.TopMost = false;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(frm);
            frm.Show();


        }

        private void selfMonitor_Click(object sender, EventArgs e)
        {
            UI.selfMonitor frm = new UI.selfMonitor();
            frm.TopLevel = false;
            frm.TopMost = false;
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void help_Click(object sender, EventArgs e)
        {
            UI.help Help = new UI.help();
            Help.Show();
        }
    }
}
