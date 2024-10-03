namespace WindowsFormsApplication1
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Random = new System.Windows.Forms.Button();
            this.btb_NhapMang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Thoat = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Random);
            this.panel1.Controls.Add(this.btb_NhapMang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 398);
            this.panel1.TabIndex = 0;
            // 
            // btn_Random
            // 
            this.btn_Random.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Random.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Random.Location = new System.Drawing.Point(57, 262);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(212, 62);
            this.btn_Random.TabIndex = 2;
            this.btn_Random.Text = "Random";
            this.btn_Random.UseVisualStyleBackColor = false;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // btb_NhapMang
            // 
            this.btb_NhapMang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btb_NhapMang.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btb_NhapMang.Location = new System.Drawing.Point(57, 169);
            this.btb_NhapMang.Name = "btb_NhapMang";
            this.btb_NhapMang.Size = new System.Drawing.Size(212, 62);
            this.btb_NhapMang.TabIndex = 1;
            this.btb_NhapMang.Text = "Nhập mảng";
            this.btb_NhapMang.UseVisualStyleBackColor = false;
            this.btb_NhapMang.Click += new System.EventHandler(this.btb_BatDau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to \r\n   2D array";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Thoat);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(344, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 398);
            this.panel2.TabIndex = 1;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.Transparent;
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.Location = new System.Drawing.Point(454, 12);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(41, 38);
            this.Thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Thoat.TabIndex = 1;
            this.Thoat.TabStop = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-69, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btb_NhapMang;
        private System.Windows.Forms.PictureBox Thoat;
        private System.Windows.Forms.Button btn_Random;
    }
}

