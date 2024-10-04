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
using System.Windows.Forms.DataVisualization;



namespace selfControl.controlUnits
{
    public partial class variableCurve : UserControl
    {

        public string ipaddress;
        public string moniorVari;

        public int abc;



        public variableCurve()
        {
            InitializeComponent();
        }


        private void startMonite_Click(object sender, EventArgs e)
        {
            uiSetting.variableCurve frm = new uiSetting.variableCurve();

            DialogResult dialogResult = frm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                ipaddress = frm.returnPLCip;
                moniorVari = frm.returnMonitorVari;

                this.label1.Text = moniorVari + "的实时曲线";

                getPLCdata();
                //refreshUI();
                timer1.Start();
            
           
              



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

                        abc = Convert.ToInt16(plc.Read(moniorVari));
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

                   

                    }));


                    Thread.Sleep(1000);
                }
                ;
            });
        }




        #region 20241004 自定义的控件可拖拽，自由移动

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

        private void textIP_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {



            monitorCurve.Series[0].Points.AddY(abc);
          
        
        }
    }
}
