using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySanBongMini.DTO;

namespace QuanLySanBongMini.DAO
{
    public class SanBongDAO
    {
        public static void addSan(String ten, double donGia)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();

                String query = "insert into SanBong(tenSan, donGia) values(@tenSan, @donGia);";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@tenSan", ten);
                command.Parameters.AddWithValue("@donGia", donGia);

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

        public static DataSet getAllSan()
        {            
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from SanBong";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);

                    dataSet = new DataSet();
                    
                    sqlDataAdapter.Fill(dataSet);

                    conn.Close();
                }
            }
            catch(SqlException e)
            {
                throw e;
            }
            return dataSet;
        }

        public static void deleteSan(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "delete from SanBong where id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        } 

        public static void updateTenSan(int id, String tenSan, double donGia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "update SanBong set tenSan = @tenSan, donGia = @donGia where id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@tenSan", tenSan);
                    command.Parameters.AddWithValue("@donGia", donGia);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

        }
    }
}
