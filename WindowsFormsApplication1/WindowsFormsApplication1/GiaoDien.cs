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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn muốn đóng giao diện?", "Đóng", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn Yes
                this.Close();
            }
        }

    
        private Form currFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currFormChild!=null)
            {
                currFormChild.Close();
            }
            currFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.BringToFront();
            childForm.Show();
        }

        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TinhToan());
            lbl_TieuDe.Text = "Tính toán trong mảng 2 chiều";
        }

        private void btn_SapXep_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_SapXep());
            lbl_TieuDe.Text = "Sắp xếp trong mảng 2 chiều";

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_TimKiem());
            lbl_TieuDe.Text = "Tìm kiếm trong mảng 2 chiều";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();  // Hiển thị lại form chính
            this.Close();// Đóng form hiện tại (OtherForm)
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn muốn đóng giao diện?", "Đóng", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {
                // Đóng form nếu người dùng chọn Yes
                this.Close();
            }
        }

      

      

     
    }
}
