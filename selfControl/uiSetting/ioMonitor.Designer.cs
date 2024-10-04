namespace selfControl
{
    partial class ioMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPara = new System.Windows.Forms.TextBox();
            this.addPara = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "监控变量";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(182, 56);
            this.textIP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(196, 35);
            this.textIP.TabIndex = 2;
            // 
            // textPara
            // 
            this.textPara.Location = new System.Drawing.Point(182, 208);
            this.textPara.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textPara.Name = "textPara";
            this.textPara.Size = new System.Drawing.Size(196, 35);
            this.textPara.TabIndex = 3;
            // 
            // addPara
            // 
            this.addPara.Location = new System.Drawing.Point(54, 288);
            this.addPara.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addPara.Name = "addPara";
            this.addPara.Size = new System.Drawing.Size(150, 46);
            this.addPara.TabIndex = 4;
            this.addPara.Text = "设置";
            this.addPara.UseVisualStyleBackColor = true;
            this.addPara.Click += new System.EventHandler(this.addPara_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "变量类型";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(432, 56);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(552, 278);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "变量填写说明\n1、监控位  DB1.DBX0.0  M0.0 Q0.0  I0.0\n2、监控整数  DB1.DBW0   MW100\n3、监控浮点数 DB100." +
    "DBD0  MD100";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "位",
            "整数",
            "浮点数"});
            this.comboBoxType.Location = new System.Drawing.Point(182, 134);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(196, 32);
            this.comboBoxType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("黑体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(440, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "注意：字母一定要大写";
            // 
            // ioMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPara);
            this.Controls.Add(this.textPara);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ioMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置变量信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPara;
        private System.Windows.Forms.Button addPara;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label4;
    }
}