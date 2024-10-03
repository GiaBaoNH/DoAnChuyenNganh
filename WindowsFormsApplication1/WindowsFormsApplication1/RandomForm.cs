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
    public partial class RandomForm : Form // Đổi tên lớp
    {
        private int[,] array2D;
        private int rows;
        private int cols;

        public RandomForm()
        {
            InitializeComponent();
        }

     

        private void Random_Load(object sender, EventArgs e)
        {

        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra giá trị nhập vào từ TextBox
            if (!int.TryParse(txt_Cot.Text, out cols) || cols <= 0 ||
                !int.TryParse(txt_Dong.Text, out rows) || rows <= 0)
            {
                MessageBox.Show("Vui lòng nhập số dòng và số cột hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            array2D = new int[rows, cols];

            // Thiết lập DataGridView
            data_MangRandom.RowCount = rows;
            data_MangRandom.ColumnCount = cols;

            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2D[i, j] = rand.Next(1, 100); // Số ngẫu nhiên từ 1 đến 100
                    data_MangRandom.Rows[i].Cells[j].Value = array2D[i, j];

                    //// Cập nhật màu sắc ô để thể hiện việc thêm giá trị
                    //data_MangRandom.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;

                    //// Đợi một khoảng thời gian để người dùng có thể thấy sự thay đổi
                    //await Task.Delay(100); // Thay đổi thời gian nếu cần
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            data_MangRandom.Rows.Clear();
            data_MangRandom.Columns.Clear();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();  // Hiển thị lại form chính
            this.Close(); // Đóng form hiện tại
        }
    }
}
