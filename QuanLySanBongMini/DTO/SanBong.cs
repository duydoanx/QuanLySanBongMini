using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    class SanBong : DAO.SanBongDAO
    {
        public int id { get; }
        public string tenSan { get; set; }
        public bool dangThue { get; set; }

        public SanBong(int id, string tenSan, bool dangThue)
        {
            this.tenSan = tenSan;
            this.id = id;
            this.dangThue = dangThue;
        }
    }
}
