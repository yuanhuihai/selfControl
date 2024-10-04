using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using System.Threading;

namespace selfControl.controlUnits
{
    public partial class ioMonitor : UserControl
    {

        public int abc;
        public float bcd;

        public string ipaddress;
        public string parameter;
        public string type;


        public ioMonitor()
        {
            InitializeComponent();
        }
        private void addValue_Click(object sender, EventArgs e)
        {


            selfControl.ioMonitor frm = new selfControl.ioMonitor();
         
            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                ipaddress = frm.returnTextIP;
                parameter = frm.returnTextPara;
                type = frm.returnType;

                this.labelIP.Text = frm.returnTextIP;
                this.labelInfo.Text = frm.returnTextPara;



                if (type == "浮点数")
                {

                    getPLCfloatdata();
                    refreshUIfloat();

                }
                else
                {
                    getPLCdata();
                    refreshUI();
                }





            }


        }





        private void getPLCdata()
        {
            Plc plc = new Plc(CpuType.S7300, ipaddress, 0, 2);
            plc.Open();


            Task.Run(() =>
            {
                while (true)
                {
                    if (plc.IsConnected)
                    {

                        abc = Convert.ToInt16(plc.Read(parameter));
                    }
                    Thread.Sleep(200);
                }
            });
        }


        private void getPLCfloatdata()
        {
            Plc plc = new Plc(CpuType.S7300, ipaddress, 0, 2);
            plc.Open();


            Task.Run(() =>
            {
                while (true)
                {
                    if (plc.IsConnected)
                    {

                        bcd = ((uint)plc.Read(parameter)).ConvertToFloat();
                    }
                    Thread.Sleep(200);

                }
            });
        }




        private void refreshUI()
        {
            Task.Run(() =>
            {
                while (true)
                {

                    this.Invoke(new Action(() =>
                    {

                        labelValue.Text = abc.ToString();


                    }));
                    Thread.Sleep(200);
                }
                ;
            });
        }

        private void refreshUIfloat()
        {
            Task.Run(() =>
            {
                while (true)
                {

                    this.Invoke(new Action(() =>
                    {

                        labelValue.Text = bcd.ToString();


                    }));
                    Thread.Sleep(200);
                }
                ;
            });
        }




        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }




    }
}
