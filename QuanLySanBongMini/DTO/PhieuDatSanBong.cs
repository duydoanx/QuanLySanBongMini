using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class PhieuDatSanBong
    {
        public PhieuDatSanBong(int id, int idSanBong, DateTime thoiGianBatDau, int soGioDat, double donGia, int idHoaDon)
        {
            this.id = id;
            this.idSanBong = idSanBong;
            this.thoiGianBatDau = thoiGianBatDau;
            this.soGioDat = soGioDat;
            this.donGia = donGia;
            this.idHoaDon = idHoaDon;
          
        }

        public int id { get;}
        public int idSanBong { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public int soGioDat { get; set; }
        public Double donGia { get; set; }
        public int idHoaDon { get; set; }
        
    }
}
