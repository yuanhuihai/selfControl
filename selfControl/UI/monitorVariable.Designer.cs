namespace selfControl.UI
{
    partial class monitorVariable
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
            this.addMoniteVari = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMoniteVari
            // 
            this.addMoniteVari.Location = new System.Drawing.Point(3, 12);
            this.addMoniteVari.Name = "addMoniteVari";
            this.addMoniteVari.Size = new System.Drawing.Size(181, 54);
            this.addMoniteVari.TabIndex = 0;
            this.addMoniteVari.Text = "添加变量";
            this.addMoniteVari.UseVisualStyleBackColor = true;
            this.addMoniteVari.Click += new System.EventHandler(this.addMoniteVari_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addMoniteVari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 490);
            this.panel1.TabIndex = 1;
            // 
            // monitorVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(974, 490);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "monitorVariable";
            this.Text = "monitorVariable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addMoniteVari;
        private System.Windows.Forms.Panel panel1;
    }
}