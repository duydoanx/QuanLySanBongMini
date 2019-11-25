using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class HoaDon
    {
        public int id { get;}
        public DateTime ngayTao { get; set; }
        public string tenKhachHang { get; set; }
        public bool daThanhToan { get; set; }

    }
}
