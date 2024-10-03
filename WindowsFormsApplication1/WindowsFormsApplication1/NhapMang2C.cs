using System;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class NhapMang2C : Form
    {
        private int[,] array2D; // Khai báo biến array2D

        public NhapMang2C()
        {
            InitializeComponent();
            this.Load += new EventHandler(NhapMang2C_Load);

        }

        // Nút để quay lại trang chủ
        private void btn_QuayLai_Click_1(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();  // Hiển thị lại form chính
            this.Close(); // Đóng form hiện tại
        }

        // Nút để xóa dữ liệu trong DataGridView
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            data_Mang2C.Rows.Clear();
            data_Mang2C.Columns.Clear();
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    Text = caption
                };
                Label lblText = new Label() { Left = 50, Top = 20, Text = text, AutoSize = true };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70 };
                confirmation.DialogResult = DialogResult.OK;
                prompt.Controls.Add(lblText);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
            }
        }

        // Nút để nhập dữ liệu vào DataGridView
        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            int rows, cols;

            // Lấy số dòng và cột từ TextBox
            if (int.TryParse(txt_Dong.Text, out rows) && int.TryParse(txt_Cot.Text, out cols) && rows > 0 && cols > 0)
            {
                // Khởi tạo mảng 2 chiều
                array2D = new int[rows, cols];

                // Lưu mảng vào DataStorage
                DuLieuNhap.SharedArray = array2D;
                DuLieuNhap.Rows = rows;
                DuLieuNhap.Columns = cols;

                // Cấu hình DataGridView
                data_Mang2C.RowCount = rows;
                data_Mang2C.ColumnCount = cols;

                // Nhập dữ liệu từ bàn phím vào mảng 2 chiều
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        string value = Prompt.ShowDialog("Nhập giá trị tại [" + i + ", " + j + "]", "Nhập giá trị");
                        int result;

                        if (int.TryParse(value, out result))
                        {
                            array2D[i, j] = result;
                            data_Mang2C.Rows[i].Cells[j].Value = result; // Cập nhật giá trị vào DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Giá trị không hợp lệ! Vui lòng nhập một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            j--; // Để yêu cầu nhập lại giá trị cho ô hiện tại
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số dòng và số cột hợp lệ!", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NhapMang2C_Load(object sender, EventArgs e)
        {
            data_Mang2C.DefaultCellStyle.ForeColor = Color.Black;  // Màu chữ toàn bộ DataGridView là màu đen
        }

        private void btn_TiepTuc_Click(object sender, EventArgs e)
        {
            GiaoDien gd = new GiaoDien();
            gd.Show();
            this.Close();
        }
    }
}
