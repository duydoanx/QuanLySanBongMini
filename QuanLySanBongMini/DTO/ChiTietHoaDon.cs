using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class ChiTietHoaDon
    {
        public int id { get; }
        public int idHoaDon { get; set; }
        public int idMatHang { get; set; }
        public int soLuong { get; set; }
        public float donGia { get; set; }
    }
}
