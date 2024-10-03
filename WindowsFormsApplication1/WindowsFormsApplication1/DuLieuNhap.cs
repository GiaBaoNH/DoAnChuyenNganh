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
    }
}
