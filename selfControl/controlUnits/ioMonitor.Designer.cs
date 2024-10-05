namespace selfControl.controlUnits
{
    partial class ioMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ioMonitor));
            this.addValue = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addValue
            // 
            this.addValue.Location = new System.Drawing.Point(217, 101);
            this.addValue.Margin = new System.Windows.Forms.Padding(6);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(137, 46);
            this.addValue.TabIndex = 14;
            this.addValue.Text = "添加变量";
            this.addValue.UseVisualStyleBackColor = true;
            this.addValue.Click += new System.EventHandler(this.addValue_Click);
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(86, 112);
            this.labelValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(142, 24);
            this.labelValue.TabIndex = 13;
            this.labelValue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "值";
            // 
            // labelIP
            // 
            this.labelIP.Location = new System.Drawing.Point(86, 66);
            this.labelIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(190, 24);
            this.labelIP.TabIndex = 11;
            this.labelIP.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "IP";
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelInfo.Location = new System.Drawing.Point(53, 0);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(215, 43);
            this.labelInfo.TabIndex = 9;
            this.labelInfo.Text = "变量名称";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ioMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addValue);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelInfo);
            this.Name = "ioMonitor";
            this.Size = new System.Drawing.Size(360, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
