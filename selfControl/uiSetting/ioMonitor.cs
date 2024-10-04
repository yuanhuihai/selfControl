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
    public partial class ioMonitor : Form
    {

        public string returnTextIP { get; set; }
        public string returnTextPara { get; set; }
        public string returnType { get; set; }

        public ioMonitor()
        {
            InitializeComponent();
        }

        private void addPara_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.returnTextIP = this.textIP.Text;
            this.returnTextPara = this.textPara.Text;
            this.returnType = this.comboBoxType.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
