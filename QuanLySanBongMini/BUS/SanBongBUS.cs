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
        public static bool addSan(String tenSan)
        {
            bool kt = true;

            try
            {
                DAO.SanBongDAO.addSan(tenSan);
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

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    String tenSan = row["tenSan"].ToString();
                    int idSan = Convert.ToInt32(row["id"]);
                    SanBong sanBong = new SanBong(idSan, tenSan);
                    dataList.Insert(0, sanBong);
                    
                }
            }
            catch (SqlException e)
            {

            }

            return dataList;
        }

        public static bool deleteSan(String sanBong)
        {
            bool kt = true;
            try
            {
                SanBongDAO.deleteSan(sanBong);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }
        public static bool updateTenSan(int id, String tenSan)
        {
            bool kt = true;
            try
            {
                SanBongDAO.updateTenSan(id, tenSan);
            }
            catch (SqlException e)
            {
                kt = false;
            }
            return kt;
        }

    }
}
