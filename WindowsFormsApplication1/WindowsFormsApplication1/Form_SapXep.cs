using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Form_SapXep : Form
    {
        public Form_SapXep()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_SapXep_Load);
        }

        private void Form_SapXep_Load(object sender, EventArgs e)
        {
            // Kiểm tra nếu mảng có dữ liệu
            if (DuLieuNhap.SharedArray != null)
            {
                int rows = DuLieuNhap.Rows;
                int cols = DuLieuNhap.Columns;

                // Cấu hình DataGridView
                data_SapXep.RowCount = rows;
                data_SapXep.ColumnCount = cols;

                // Điền dữ liệu từ DataStorage vào DataGridView
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        data_SapXep.Rows[i].Cells[j].Value = DuLieuNhap.SharedArray[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void data_SapXep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       
    }
}
