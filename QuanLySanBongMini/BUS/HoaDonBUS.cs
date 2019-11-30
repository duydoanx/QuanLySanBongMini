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
    public class HoaDonBUS
    {
        public static ArrayList getAllHoaDon()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = HoaDonDAO.getAllHoaDon();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    DateTime ngayTao = (DateTime)row["ngayTao"];
                    string tenKhachHang = row["tenKhachHang"].ToString();
                    bool daThanhToan = (bool)row["daThanhToan"];
                    dataList.Add(new HoaDon(id, ngayTao, tenKhachHang, daThanhToan));

                }
            }
            catch (SqlException e)
            {

            }
            return dataList;
        }
        public static bool addHoaDon(HoaDon hoaDon)
        {
            bool kt = true;

            try
            {                
                HoaDonDAO.addHoaDon(hoaDon.ngayTao, hoaDon.tenKhachHang, hoaDon.daThanhToan);               

            }
            catch (SqlException e)
            {
                kt = false;

            }
            return kt;
        }
        public static HoaDon getHoaDon(int id)
        {
            HoaDon hoaDon = null;

            try
            {
                DataSet tam = HoaDonDAO.getHoaDon(id);
                DataRow dataRow = tam.Tables[0].Rows[0];
                DateTime ngayTao = (DateTime)dataRow["ngayTao"];
                string tenKhachHang = dataRow["tenKhachHang"].ToString();
                bool daThanhToan = (bool)dataRow["daThanhToan"];
                hoaDon = new HoaDon(id, ngayTao, tenKhachHang, daThanhToan);               

            }
            catch (SqlException e)
            {
                

            }
            return hoaDon;
        }
        public static bool deleteHoaDon(int id)
        {
            bool kt = true;
            try
            {
                HoaDonDAO.deleteHoaDon(id);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
        public static HoaDon getLastHoaDon()
        {
            HoaDon hoaDon = null;

            try
            {
                DataSet tam = HoaDonDAO.getLastHoaDon();
                DataRow dataRow = tam.Tables[0].Rows[0];
                int id = Convert.ToInt32(dataRow["id"]);
                DateTime ngayTao = (DateTime)dataRow["ngayTao"];
                string tenKhachHang = dataRow["tenKhachHang"].ToString();
                bool daThanhToan = (bool)dataRow["daThanhToan"];
                hoaDon = new HoaDon(id, ngayTao, tenKhachHang, daThanhToan);

            }
            catch (SqlException e)
            {


            }
            return hoaDon;
        }
        public static bool updateHoaDon(HoaDon hoaDon)
        {
            bool kt = true;
            try
            {
                HoaDonDAO.updateHoaDon(hoaDon.id, hoaDon.tenKhachHang, hoaDon.daThanhToan);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
