using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class MatHangDAO
    {
        public static void addMatHang(string tenMatHang, int idNganhHang, float donGia)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();

                String query = "insert into MatHang(tenMatHang, idNganhHang, donGia) values (@tenMatHang, @idNganhHang, @donGia);";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@tenMatHang", tenMatHang);
                command.Parameters.AddWithValue("@idNganhHang", idNganhHang);
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
        public static DataSet getAllMatHang()
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from MatHang";

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

        public static void updateMatHang(int id, string tenMatHang, int idNganhHang, float donGia, int soLuong)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "update MatHang set tenMatHang = @tenMatHang, idNganhHang = @idNganhHang" +
                        ", donGia = @donGia, soLuong = @soLuong where id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@tenMatHang", tenMatHang);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idNganhHang", idNganhHang);
                    command.Parameters.AddWithValue("@donGia", donGia);
                    command.Parameters.AddWithValue("@soLuong", soLuong);

                    command.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

        }
        public static void deleteMatHang(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "delete from MatHang where id = @id";
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

        public static DataSet getMatHangFromIdNganhHang(int idNganhHang)
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from MatHang where idNganhHang = @idNganhHang";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@idNganhHang", idNganhHang);

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

        public static DataSet getMatHang(int id)
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from MatHang where id = @id";
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
    }
}
