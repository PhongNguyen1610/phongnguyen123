namespace BT1chuong4
{
    partial class menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chàoMừngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chươngTrìnhTínhTổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chàoMừngToolStripMenuItem,
            this.tínhTổngToolStripMenuItem,
            this.chươngTrìnhTínhTổngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chàoMừngToolStripMenuItem
            // 
            this.chàoMừngToolStripMenuItem.Name = "chàoMừngToolStripMenuItem";
            this.chàoMừngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.chàoMừngToolStripMenuItem.Text = "Chào mừng";
            this.chàoMừngToolStripMenuItem.Click += new System.EventHandler(this.chàoMừngToolStripMenuItem_Click);
            // 
            // tínhTổngToolStripMenuItem
            // 
            this.tínhTổngToolStripMenuItem.Name = "tínhTổngToolStripMenuItem";
            this.tínhTổngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.tínhTổngToolStripMenuItem.Text = "Tính tổng";
            this.tínhTổngToolStripMenuItem.Click += new System.EventHandler(this.tínhTổngToolStripMenuItem_Click);
            // 
            // chươngTrìnhTínhTổngToolStripMenuItem
            // 
            this.chươngTrìnhTínhTổngToolStripMenuItem.Name = "chươngTrìnhTínhTổngToolStripMenuItem";
            this.chươngTrìnhTínhTổngToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.chươngTrìnhTínhTổngToolStripMenuItem.Text = "chương trình tính tổng";
            this.chươngTrìnhTínhTổngToolStripMenuItem.Click += new System.EventHandler(this.chươngTrìnhTínhTổngToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chàoMừngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhTínhTổngToolStripMenuItem;
    }
}