namespace selfControl.controlUnits
{
    partial class variableCurve
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monitorCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startMonite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monitorCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // monitorCurve
            // 
            chartArea1.Name = "ChartArea1";
            this.monitorCurve.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monitorCurve.Legends.Add(legend1);
            this.monitorCurve.Location = new System.Drawing.Point(6, 64);
            this.monitorCurve.Margin = new System.Windows.Forms.Padding(6);
            this.monitorCurve.Name = "monitorCurve";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.monitorCurve.Series.Add(series1);
            this.monitorCurve.Size = new System.Drawing.Size(928, 388);
            this.monitorCurve.TabIndex = 0;
            this.monitorCurve.Text = "chart1";
            // 
            // startMonite
            // 
            this.startMonite.Location = new System.Drawing.Point(14, 6);
            this.startMonite.Margin = new System.Windows.Forms.Padding(6);
            this.startMonite.Name = "startMonite";
            this.startMonite.Size = new System.Drawing.Size(210, 46);
            this.startMonite.TabIndex = 1;
            this.startMonite.Text = "设置监控变量";
            this.startMonite.UseVisualStyleBackColor = true;
            this.startMonite.Click += new System.EventHandler(this.startMonite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // variableCurve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startMonite);
            this.Controls.Add(this.monitorCurve);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "variableCurve";
            this.Size = new System.Drawing.Size(940, 458);
            ((System.ComponentModel.ISupportInitialize)(this.monitorCurve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart monitorCurve;
        private System.Windows.Forms.Button startMonite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
