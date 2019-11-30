using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(int id, int idHoaDon, int idMatHang, int soLuong, double donGia)
        {
            this.id = id;
            this.idHoaDon = idHoaDon;
            this.idMatHang = idMatHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public int id { get; }
        public int idHoaDon { get; set; }
        public int idMatHang { get; set; }
        public int soLuong { get; set; }
        public double donGia { get; set; }
    }
}
