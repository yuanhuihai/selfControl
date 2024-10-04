using System;
using System.Windows.Forms;

namespace selfControl.UI
{
    public partial class selfMonitor : Form
    {
        public selfMonitor()
        {
            InitializeComponent();
        }

        private void addMonitorVari_Click(object sender, EventArgs e)
        {
            



            controlUnits.ioMonitor aa = new controlUnits.ioMonitor();
            this.panel1.Controls.Add(aa);
        }

        private void addMonitorCurve_Click(object sender, EventArgs e)
        {
            controlUnits.variableCurve addCurve = new controlUnits.variableCurve ();

            this.panel1.Controls.Add(addCurve);
        }
    }
}
