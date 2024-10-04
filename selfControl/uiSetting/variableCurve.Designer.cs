namespace selfControl.uiSetting
{
    partial class variableCurve
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
            this.plcIP = new System.Windows.Forms.TextBox();
            this.moniorVari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startMonitor = new System.Windows.Forms.Button();
            this.cancelMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // plcIP
            // 
            this.plcIP.Location = new System.Drawing.Point(112, 40);
            this.plcIP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plcIP.Name = "plcIP";
            this.plcIP.Size = new System.Drawing.Size(196, 35);
            this.plcIP.TabIndex = 1;
            // 
            // moniorVari
            // 
            this.moniorVari.Location = new System.Drawing.Point(112, 120);
            this.moniorVari.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.moniorVari.Name = "moniorVari";
            this.moniorVari.Size = new System.Drawing.Size(196, 35);
            this.moniorVari.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "变量";
            // 
            // startMonitor
            // 
            this.startMonitor.Location = new System.Drawing.Point(48, 202);
            this.startMonitor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.startMonitor.Name = "startMonitor";
            this.startMonitor.Size = new System.Drawing.Size(150, 46);
            this.startMonitor.TabIndex = 4;
            this.startMonitor.Text = "开始监控";
            this.startMonitor.UseVisualStyleBackColor = true;
            this.startMonitor.Click += new System.EventHandler(this.startMonitor_Click);
            // 
            // cancelMonitor
            // 
            this.cancelMonitor.Location = new System.Drawing.Point(228, 202);
            this.cancelMonitor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelMonitor.Name = "cancelMonitor";
            this.cancelMonitor.Size = new System.Drawing.Size(150, 46);
            this.cancelMonitor.TabIndex = 5;
            this.cancelMonitor.Text = "取消";
            this.cancelMonitor.UseVisualStyleBackColor = true;
            this.cancelMonitor.Click += new System.EventHandler(this.cancelMonitor_Click);
            // 
            // variableCurve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 272);
            this.Controls.Add(this.cancelMonitor);
            this.Controls.Add(this.startMonitor);
            this.Controls.Add(this.moniorVari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plcIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "variableCurve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "variableCurve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plcIP;
        private System.Windows.Forms.TextBox moniorVari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startMonitor;
        private System.Windows.Forms.Button cancelMonitor;
    }
}