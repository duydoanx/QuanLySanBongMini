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
    public class PhieuNhapHangBUS
    {
        public static bool addPhieuNhapHang(PhieuNhapHang phieuNhapHang)
        {
            bool kt = true;

            try
            {
                PhieuNhapHangDAO.addPhieuNhapHang(phieuNhapHang.idMatHang, phieuNhapHang.ngayNhap, 
                    phieuNhapHang.soLuong, phieuNhapHang.tongTien);
            }
            catch (SqlException e)
            {
                kt = false;

            }
            return kt;
        }

        public static ArrayList getAllPhieuNhapHang()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = PhieuNhapHangDAO.getAllPhieuNhapHang();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                
                    int id = Convert.ToInt32(row["id"]);
                    int idMatHang = Convert.ToInt32(row["idMatHang"]);
                    DateTime ngayNhap = (DateTime) row["ngayNhap"];
                    int soLuong = Convert.ToInt32(row["soLuong"]);
                    float tongTien = (float)Convert.ToDouble(row["TongTien"]);
                    PhieuNhapHang phieuNhapHang = new PhieuNhapHang(id, idMatHang, ngayNhap, soLuong, tongTien);
                    dataList.Insert(0, phieuNhapHang);

                }
            }
            catch (SqlException e)
            {

            }

            return dataList;
        }

        public static bool deletePhieuNhapHang(int id)
        {
            bool kt = true;
            try
            {
                PhieuNhapHangDAO.deletePhieuNhapHang(id);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
}
