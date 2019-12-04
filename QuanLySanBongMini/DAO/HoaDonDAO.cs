using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class HoaDonDAO
    {
        public static void addHoaDon(DateTime ngayTao, string tenKhachHang, bool daThanhToan)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();

                String query = "insert into HoaDon(ngayTao, tenKhachHang, daThanhToan) " +
                       "values (@ngayTao, @tenKhachHang, @daThanhToan);";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@ngayTao", ngayTao);
                command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                if (daThanhToan)
                {
                    command.Parameters.AddWithValue("@daThanhToan", 1);
                }
                else
                {
                    command.Parameters.AddWithValue("@daThanhToan", 0);
                }
                

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
        public static DataSet getAllHoaDon()
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from HoaDon";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);

                    dataSet = new DataSet();

                    sqlDataAdapter.Fill(dataSet);

                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dataSet;
        }
        public static DataSet getHoaDon(int id)
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from HoaDon where id = @id";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                    dataSet = new DataSet();

                    sqlDataAdapter.Fill(dataSet);

                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dataSet;
        }
        public static void deleteHoaDon(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "delete from HoaDon where id = @id";
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
        public static DataSet getLastHoaDon()
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "SELECT TOP 1 * FROM HoaDon ORDER BY ID DESC";                    

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);

                    dataSet = new DataSet();

                    sqlDataAdapter.Fill(dataSet);

                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dataSet;
        }

        public static void updateHoaDon(int id, string tenKhachHang, bool daThanhToan)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "update HoaDon set tenKhachHang = @tenKhachHang, daThanhToan = @daThanhToan where id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@tenKhachHang", tenKhachHang);
                    
                    if (daThanhToan)
                    {
                        command.Parameters.AddWithValue("@daThanhToan", 1);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@daThanhToan", 0);
                    }

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
