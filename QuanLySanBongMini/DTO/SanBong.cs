using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTO
{
    class SanBong
    {
        public int id { get;}
        public string tenSan { get; set; }

        public SanBong(int id, string tenSan)
        {
            this.tenSan = tenSan;
            this.id = id;
        }
    }
}
