using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class MatHang
    {
        public MatHang(int id, string tenMatHang, int idNganhHang, float donGia, int soLuong)
        {
            this.id = id;
            this.tenMatHang = tenMatHang;
            this.idNganhHang = idNganhHang;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }
        public MatHang(string tenMatHang, int idNganhHang, float donGia)
        {            
            this.tenMatHang = tenMatHang;
            this.idNganhHang = idNganhHang;
            this.donGia = donGia;
        }

        public int id { get; }
        public string tenMatHang { get; set; }
        public int idNganhHang { get; set; }
        public float donGia { get; set; }
        public int soLuong { get; set; }

    }
}
