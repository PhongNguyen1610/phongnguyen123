namespace BT1chuong4
{
    partial class Tinhtong
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
            this.a = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.btnTinhtong = new System.Windows.Forms.Button();
            this.lbTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(86, 54);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(16, 17);
            this.a.TabIndex = 0;
            this.a.Text = "a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(188, 54);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 1;
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(89, 103);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(16, 17);
            this.b.TabIndex = 2;
            this.b.Text = "b";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(188, 103);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 22);
            this.txtb.TabIndex = 3;
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
            // 
            // btnTinhtong
            // 
            this.btnTinhtong.Location = new System.Drawing.Point(144, 247);
            this.btnTinhtong.Name = "btnTinhtong";
            this.btnTinhtong.Size = new System.Drawing.Size(144, 65);
            this.btnTinhtong.TabIndex = 4;
            this.btnTinhtong.Text = "Tính tổng";
            this.btnTinhtong.UseVisualStyleBackColor = true;
            this.btnTinhtong.Click += new System.EventHandler(this.btnTinhtong_Click);
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(429, 271);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(0, 17);
            this.lbTong.TabIndex = 5;
            // 
            // Tinhtong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.btnTinhtong);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.b);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.a);
            this.Name = "Tinhtong";
            this.Text = "Tinhtong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btnTinhtong;
        private System.Windows.Forms.Label lbTong;
    }
}