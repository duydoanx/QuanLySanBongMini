using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class NganhHangDAO
    {
        public static void addNganhHang(int id)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();

                String query = "insert into NganhHang(tenNganhHang) values(@id);";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@id", id);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    throw e;
                }

                conn.Close();
            }

        }
        /*
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
        }*/
    }
}
