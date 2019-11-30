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
    public class MatHangBUS
    {
        public static bool addMatHang(MatHang matHang)
        {
            bool kt = true;

            try
            {
                MatHangDAO.addMatHang(matHang.tenMatHang, matHang.idNganhHang, matHang.donGia);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static ArrayList getAllMatHang()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = MatHangDAO.getAllMatHang();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    string tenMatHang = row["tenMatHang"].ToString();
                    int idNganhHang = Convert.ToInt32(row["idNganhHang"]);
                    float donGian = (float)Convert.ToDouble(row["donGia"]);
                    int soLuong = Convert.ToInt32(row["soLuong"]);
                    MatHang matHang = new MatHang(id, tenMatHang, idNganhHang, donGian, soLuong);
                    dataList.Insert(0, matHang);

                }
            }
            catch (SqlException e)
            {

            }

            return dataList;
        }
        public static bool updateMatHang(MatHang matHang)
        {
            bool kt = true;
            try
            {                
                MatHangDAO.updateMatHang(matHang.id, matHang.tenMatHang, matHang.idNganhHang, matHang.donGia, matHang.soLuong);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
        public static bool deleteMatHang(int id)
        {
            bool kt = true;
            try
            {
                MatHangDAO.deleteMatHang(id);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
        public static ArrayList getAllMatHangFromNganhHang(int idNganhHang)
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = MatHangDAO.getMatHangFromIdNganhHang(idNganhHang);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    string tenMatHang = row["tenMatHang"].ToString();
                    //int idNganhHang1 = Convert.ToInt32(row["idNganhHang"]);
                    float donGian = (float)Convert.ToDouble(row["donGia"]);
                    int soLuong = Convert.ToInt32(row["soLuong"]);
                    MatHang matHang = new MatHang(id, tenMatHang, idNganhHang, donGian, soLuong);
                    dataList.Insert(0, matHang);

                }
            }
            catch (SqlException e)
            {

            }

            return dataList;
        }

        public static MatHang getMatHang(int idNganhHang)
        {
            MatHang matHang = null;
            try
            {
                DataSet dataSet = MatHangDAO.getMatHang(idNganhHang);

                DataRow row = dataSet.Tables[0].Rows[0];              

                int id = Convert.ToInt32(row["id"]);
                string tenMatHang = row["tenMatHang"].ToString();
                //int idNganhHang1 = Convert.ToInt32(row["idNganhHang"]);
                float donGian = (float)Convert.ToDouble(row["donGia"]);
                int soLuong = Convert.ToInt32(row["soLuong"]);
                matHang = new MatHang(id, tenMatHang, idNganhHang, donGian, soLuong);               
            }
            catch (SqlException e)
            {

            }
            return matHang;
        }
    }
}
