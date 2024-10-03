namespace WindowsFormsApplication1
{
    partial class RandomForm
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.txt_Dong = new System.Windows.Forms.TextBox();
            this.txt_Cot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data_MangRandom = new System.Windows.Forms.DataGridView();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TiepTuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_MangRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Lavender;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Xoa.Location = new System.Drawing.Point(520, 171);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(97, 38);
            this.btn_Xoa.TabIndex = 26;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.BackColor = System.Drawing.Color.Lavender;
            this.btn_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Nhap.Location = new System.Drawing.Point(520, 125);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(97, 38);
            this.btn_Nhap.TabIndex = 25;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = false;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // txt_Dong
            // 
            this.txt_Dong.Location = new System.Drawing.Point(334, 178);
            this.txt_Dong.Name = "txt_Dong";
            this.txt_Dong.Size = new System.Drawing.Size(111, 22);
            this.txt_Dong.TabIndex = 24;
            // 
            // txt_Cot
            // 
            this.txt_Cot.Location = new System.Drawing.Point(334, 125);
            this.txt_Cot.Name = "txt_Cot";
            this.txt_Cot.Size = new System.Drawing.Size(111, 22);
            this.txt_Cot.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(151, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nhập số dòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(151, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nhập số cột :";
            // 
            // data_MangRandom
            // 
            this.data_MangRandom.BackgroundColor = System.Drawing.Color.Azure;
            this.data_MangRandom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_MangRandom.GridColor = System.Drawing.Color.Black;
            this.data_MangRandom.Location = new System.Drawing.Point(96, 238);
            this.data_MangRandom.Name = "data_MangRandom";
            this.data_MangRandom.RowTemplate.Height = 24;
            this.data_MangRandom.Size = new System.Drawing.Size(614, 294);
            this.data_MangRandom.TabIndex = 20;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_QuayLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuayLai.Location = new System.Drawing.Point(51, 554);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(119, 40);
            this.btn_QuayLai.TabIndex = 19;
            this.btn_QuayLai.Text = "Quay Lại";
            this.btn_QuayLai.UseVisualStyleBackColor = true;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UVN Chim Bien Nang", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 60);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nhập mảng radom";
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_TiepTuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_TiepTuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TiepTuc.Location = new System.Drawing.Point(663, 554);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(119, 40);
            this.btn_TiepTuc.TabIndex = 27;
            this.btn_TiepTuc.Text = "Tiếp Tục";
            this.btn_TiepTuc.UseVisualStyleBackColor = true;
            this.btn_TiepTuc.Click += new System.EventHandler(this.btn_TiepTuc_Click);
            // 
            // RandomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 606);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Nhap);
            this.Controls.Add(this.txt_Dong);
            this.Controls.Add(this.txt_Cot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data_MangRandom);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomForm";
            ((System.ComponentModel.ISupportInitialize)(this.data_MangRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.TextBox txt_Dong;
        private System.Windows.Forms.TextBox txt_Cot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_MangRandom;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TiepTuc;
    }
}