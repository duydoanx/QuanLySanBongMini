using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections;
using System.Data;
using QuanLySanBongMini.DTO;
using QuanLySanBongMini.DAO;

namespace QuanLySanBongMini.BUS
{
    public class SanBongBUS
    {
        public static bool addSan(String tenSan, double donGia)
        {
            bool kt = true;

            try
            {
                DAO.SanBongDAO.addSan(tenSan, donGia);
            }
            catch(SqlException e)
            {
                kt = false;
               
            }
            return kt;
        }

        public static ArrayList getAllSan()
        { 
            ArrayList dataList = new ArrayList();
            try
            {
                DataSet dataSet = SanBongDAO.getAllSan();
                ArrayList phieuDatSanBongList;
                DateTime thoiGianBatDau, thoiGianKetThuc;             
                int soSanhKetThuc, soSanhBatDau;
                DateTime now = DateTime.Now;
                bool dangThue;
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    String tenSan = row["tenSan"].ToString();
                    int idSan = Convert.ToInt32(row["id"]);
                    double donGia = Convert.ToInt32(row["donGia"]);
                    dangThue = false;

                    phieuDatSanBongList = PhieuDatSanBongBUS.getAllPhieuDatSanBong(idSan);
                    foreach (PhieuDatSanBong phieuDatSan in phieuDatSanBongList)
                    {
                        thoiGianBatDau = phieuDatSan.thoiGianBatDau;
                        
                        thoiGianKetThuc = thoiGianBatDau.AddHours((double)phieuDatSan.soGioDat);                        

                        soSanhKetThuc = DateTime.Compare(thoiGianKetThuc, now);
                        soSanhBatDau = DateTime.Compare(thoiGianBatDau, now);                                             

                        if(soSanhBatDau<0 && soSanhKetThuc > 0)
                        {
                            dangThue = true;
                            break;
                        }
                    }                    
                    SanBong sanBong = new SanBong(idSan, tenSan, dangThue, donGia);                  
                   
                    dataList.Insert(0, sanBong);
                    
                }
            }
            catch (SqlException e)
            {

            }

            return dataList;
        }

        public static bool deleteSan(int id)
        {
            bool kt = true;
            try
            {
                SanBongDAO.deleteSan(id);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }

        public static bool updateTenSan(int id, String tenSan, double donGia)
        {
            bool kt = true;
            try
            {
                SanBongDAO.updateTenSan(id, tenSan, donGia);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }

    }
}
