using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class SanBong
    {
        public int id { get; }
        public string tenSan { get; set; }
        public double donGia { get; set; }
        public bool dangThue { get; set; }

        public SanBong(int id, string tenSan, bool dangThue, double donGia)
        {
            this.tenSan = tenSan;
            this.id = id;
            this.dangThue = dangThue;
            this.donGia = donGia;
        }
    }
}
