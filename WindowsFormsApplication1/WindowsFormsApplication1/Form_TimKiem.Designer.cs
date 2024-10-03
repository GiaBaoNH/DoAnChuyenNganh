namespace WindowsFormsApplication1
{
    partial class Form_TimKiem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cob_TinhToan = new System.Windows.Forms.ComboBox();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.lbl_KetQua);
            this.panel2.Controls.Add(this.btn_Nhap);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.cob_TinhToan);
            this.panel2.Controls.Add(this.btn_Tinh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 303);
            this.panel2.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(973, 47);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(114, 178);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(101, 28);
            this.lbl_KetQua.TabIndex = 6;
            this.lbl_KetQua.Text = "Kết quả :";
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Nhap.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F);
            this.btn_Nhap.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Nhap.Location = new System.Drawing.Point(648, 63);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(140, 47);
            this.btn_Nhap.TabIndex = 5;
            this.btn_Nhap.Text = "Nhập";
            this.btn_Nhap.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Xoa.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F);
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Xoa.Location = new System.Drawing.Point(648, 213);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(140, 47);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // cob_TinhToan
            // 
            this.cob_TinhToan.FormattingEnabled = true;
            this.cob_TinhToan.Items.AddRange(new object[] {
            "Tìm kiếm số k trong mảng",
            "Tìm số lớn nhất trong mảng",
            "Tìm số nhỏ nhất trong mảng"});
            this.cob_TinhToan.Location = new System.Drawing.Point(233, 111);
            this.cob_TinhToan.Name = "cob_TinhToan";
            this.cob_TinhToan.Size = new System.Drawing.Size(291, 24);
            this.cob_TinhToan.TabIndex = 1;
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Tinh.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F);
            this.btn_Tinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Tinh.Location = new System.Drawing.Point(648, 138);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(140, 47);
            this.btn_Tinh.TabIndex = 3;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Chim Bien Nang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phép toán";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 414);
            this.panel1.TabIndex = 8;
            // 
            // Form_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_TimKiem";
            this.Text = "Form_TimKiem";
            this.Load += new System.EventHandler(this.Form_TimKiem_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.Button btn_Nhap;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cob_TinhToan;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;


    }
}