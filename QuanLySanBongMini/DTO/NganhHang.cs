using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    public class NganhHang
    {
        public NganhHang(int id, string tenNganhHang)
        {
            this.id = id;
            this.tenNganhHang = tenNganhHang;
        }

        public int id { get; }
        public string tenNganhHang { get; set; }

    }
}
