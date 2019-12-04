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
    public class PhieuDatSanBongBUS
    {
        public static ArrayList getAllPhieuDatSanBong(int idSanBong)
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = PhieuDatSanBongDAO.getAllPhieuDatSanBong(idSanBong);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    DateTime thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                    //int idNganhHang1 = Convert.ToInt32(row["idNganhHang"]);
                    int soGioDat = Convert.ToInt32(row["soGioDat"]);
                    float donGia = (float)Convert.ToDouble(row["donGia"]);
                    int idHoaDon = 0;
                    
                    idHoaDon = Convert.ToInt32(row["idHoaDon"]);                    
                    
                    PhieuDatSanBong phieuDatSanBong = new PhieuDatSanBong(id, idSanBong, thoiGianBatDau, soGioDat, donGia, idHoaDon);
                    dataList.Add(phieuDatSanBong);

                }
            }
            catch (SqlException e)
            {

            }
            return dataList;
        }
        public static PhieuDatSanBong getLatestPhieuDatSanBong(int idSanBong)
        {
            PhieuDatSanBong phieuDatSanBong = null;
            try
            {
                DataSet dataSet = PhieuDatSanBongDAO.getAllPhieuDatSanBong(idSanBong);

                DataRow row = dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count-1];                

                int id = Convert.ToInt32(row["id"]);
                DateTime thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                //int idNganhHang1 = Convert.ToInt32(row["idNganhHang"]);
                int soGioDat = Convert.ToInt32(row["soGioDat"]);
                float donGia = (float)Convert.ToDouble(row["donGia"]);
                int idHoaDon = 0;              
                idHoaDon = Convert.ToInt32(row["idHoaDon"]);              
                
                phieuDatSanBong = new PhieuDatSanBong(id, idSanBong, thoiGianBatDau, soGioDat, donGia, idHoaDon);
                
            }
            catch (SqlException e)
            {

            }
            return phieuDatSanBong;
        }
        public static ArrayList getAllPhieuDatSanBong()
        {
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = PhieuDatSanBongDAO.getAllPhieuDatSanBong();

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {

                    int id = Convert.ToInt32(row["id"]);
                    int idSanBong = Convert.ToInt32(row["idSanBong"]);
                    DateTime thoiGianBatDau = (DateTime)row["thoiGianBatDau"];                  
                    int soGioDat = Convert.ToInt32(row["soGioDat"]);
                    float donGia = (float)Convert.ToDouble(row["donGia"]);
                    int idHoaDon = 0;                    
                    idHoaDon = Convert.ToInt32(row["idHoaDon"]);
                    
                    PhieuDatSanBong phieuDatSanBong = new PhieuDatSanBong(id, idSanBong, thoiGianBatDau, soGioDat, donGia, idHoaDon);
                    dataList.Add(phieuDatSanBong);

                }
            }
            catch (SqlException e)
            {

            }
            return dataList;
        }
        public static bool addPhieuDatSanBong(PhieuDatSanBong phieuDatSanBong)
        {
            bool kt = true;

            try
            {               
                PhieuDatSanBongDAO.addPhieuDatSanBong(phieuDatSanBong.idSanBong, phieuDatSanBong.thoiGianBatDau,
                    phieuDatSanBong.soGioDat, phieuDatSanBong.donGia, phieuDatSanBong.idHoaDon);
               
            }
            catch (SqlException e)
            {
                kt = false;

            }
            return kt;
        }
        public static bool deletePhieuDatSanBong(int id)
        {
            bool kt = true;
            try
            {
                PhieuDatSanBongDAO.deletePhieuDatSanBong(id);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool updatePhieuDatSanBong(PhieuDatSanBong phieuDatSanBong)
        {
            bool kt = true;
            try
            {
                PhieuDatSanBongDAO.updatePhieuDatSanBong(phieuDatSanBong.id, phieuDatSanBong.idSanBong, phieuDatSanBong.thoiGianBatDau,
                    phieuDatSanBong.soGioDat, phieuDatSanBong.donGia, phieuDatSanBong.idHoaDon);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
    }
    
}
