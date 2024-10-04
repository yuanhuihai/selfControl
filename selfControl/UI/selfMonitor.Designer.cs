namespace selfControl.UI
{
    partial class selfMonitor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMonitorVari = new System.Windows.Forms.Button();
            this.addMonitorCurve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addMonitorCurve);
            this.panel1.Controls.Add(this.addMonitorVari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 490);
            this.panel1.TabIndex = 0;
            // 
            // addMonitorVari
            // 
            this.addMonitorVari.Location = new System.Drawing.Point(3, 12);
            this.addMonitorVari.Name = "addMonitorVari";
            this.addMonitorVari.Size = new System.Drawing.Size(195, 52);
            this.addMonitorVari.TabIndex = 0;
            this.addMonitorVari.Text = "添加IO变量";
            this.addMonitorVari.UseVisualStyleBackColor = true;
            this.addMonitorVari.Click += new System.EventHandler(this.addMonitorVari_Click);
            // 
            // addMonitorCurve
            // 
            this.addMonitorCurve.Location = new System.Drawing.Point(204, 12);
            this.addMonitorCurve.Name = "addMonitorCurve";
            this.addMonitorCurve.Size = new System.Drawing.Size(195, 52);
            this.addMonitorCurve.TabIndex = 1;
            this.addMonitorCurve.Text = "添加曲线";
            this.addMonitorCurve.UseVisualStyleBackColor = true;
            this.addMonitorCurve.Click += new System.EventHandler(this.addMonitorCurve_Click);
            // 
            // selfMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 490);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selfMonitor";
            this.Text = "selfMonitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addMonitorCurve;
        private System.Windows.Forms.Button addMonitorVari;
    }
}