using QuanLySanBongMini.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.BUS
{
    public class NganhHangBUS
    {
        public static bool addNganhHang(int id)
        {
            bool kt = true;

            try
            {
                NganhHangDAO.addNganhHang(id);
            }
            catch (SqlException e)
            {
                kt = false;

            }
            return kt;
        }
    }
}
