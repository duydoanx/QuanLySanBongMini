using QuanLySanBongMini.DAO;
using QuanLySanBongMini.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.BUS
{
    public class NganhHangBUS
    {
        public static bool addNganhHang(string ten)
        {
            bool kt = true;

            try
            {
                NganhHangDAO.addNganhHang(ten);
            }
            catch (SqlException e)
            {
                kt = false;

            }
            return kt;
        }

        public static ArrayList getAllNganhHang()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = NganhHangDAO.getAllNganhHang();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    String tenNganhHang = row["tenNganhHang"].ToString();
                    int id = Convert.ToInt32(row["id"]);
                    NganhHang nganhHang = new NganhHang(id, tenNganhHang);
                    dataList.Insert(0, nganhHang);

                }
            }
            catch (SqlException e)
            {

            }

            return dataList;
        }
        public static bool updateTenNganhHang(int id, String tenNganhHang)
        {
            bool kt = true;
            try
            {
                NganhHangDAO.updateTenNganhHang(id, tenNganhHang);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool deleteNganhHang(int id)
        {
            bool kt = true;
            try
            {
                NganhHangDAO.deleteNganhHang(id);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
