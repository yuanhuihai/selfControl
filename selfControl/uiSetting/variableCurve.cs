using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selfControl.uiSetting
{
    public partial class variableCurve : Form
    {

    


        public string returnPLCip { get; set; }
        public string returnMonitorVari { get; set; }



        public variableCurve()
        {
            InitializeComponent();
        }

        private void startMonitor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.returnPLCip = this.plcIP.Text;
            this.returnMonitorVari = this.moniorVari.Text;
         
            this.Close();



        }

        private void cancelMonitor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
