using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class DuLieuNhap
    {
        public static int[,] SharedArray { get; set; } // Mảng chia sẻ
        public static int Rows { get; set; } // Số dòng
        public static int Columns { get; set; } // Số cột

        // Phương thức để lấy giá trị tại vị trí nhất định
        public static int GetValue(int row, int col)
        {
            if (SharedArray != null && row < Rows && col < Columns)
            {
                return SharedArray[row, col];
            }
            throw new IndexOutOfRangeException("Vị trí không hợp lệ.");
        }
    }
}
