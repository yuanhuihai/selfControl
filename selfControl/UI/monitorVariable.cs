using System;
using System.Windows.Forms;

namespace selfControl.UI
{
    public partial class monitorVariable : Form
    {

        int addcount = 0;
        layOut layout = new layOut();


        public monitorVariable()
        {
            InitializeComponent();
        }


        //20241004
        //panel控件中添加几个用户自定义的 mointorVariable控件 
        public void addControlUnit(int count)
        {

            //每行有几个
            int colcount = (this.panel1.Width - layout.leftGap - layout.rightGap) / (layout.width + layout.rowGap);

            if (colcount > 0)
            {
                for (int i = 0; i < count; i++)
                {

                    int colindex = i / colcount;  //取整数
                    int rowindex = i % colcount;  //取余数


                    int locationX = layout.leftGap + rowindex * (layout.width + layout.colGap);
                    int locationY = layout.topGap + colindex * (layout.height + layout.rowGap);
                    controlUnits.ioMonitor mone = new controlUnits.ioMonitor();

                    mone.Location = new System.Drawing.Point(locationX, locationY);

                    mone.Size = new System.Drawing.Size(layout.width, layout.height);
                    this.panel1.Controls.Add(mone);
                }
            }



        }

        private void addMoniteVari_Click(object sender, EventArgs e)
        {
            addcount++;//添加一个控件

            addControlUnit(addcount);
        }
    }
}
