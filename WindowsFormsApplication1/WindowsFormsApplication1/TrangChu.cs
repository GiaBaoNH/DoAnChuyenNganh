using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn muốn đóng giao diện?", "Đóng", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn Yes
                this.Close();
            }
        }

        private void btb_BatDau_Click(object sender, EventArgs e)
        {
            NhapMang2C nm = new NhapMang2C();
            nm.Show();
            this.Visible = false;
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            GiaoDien gf = new GiaoDien();
            gf.Show();
            this.Visible = false;
            //RandomForm gd = new RandomForm();
            //gd.Show();
            //this.Visible = false;
        }
    }
}
