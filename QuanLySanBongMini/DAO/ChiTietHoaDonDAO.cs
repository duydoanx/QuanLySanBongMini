using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class ChiTietHoaDonDAO
    {
        public static void addChiTietHoaDon(int idHoaDon, int idMatHang, int soLuong, double donGia)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();

                String query = "insert into ChiTietHoaDon(idHoaDon, idMatHang, soLuong, donGia) " +
                       "values (@idHoaDon, @idMatHang, @soLuong, @donGia);";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                command.Parameters.AddWithValue("@idMatHang", idMatHang);
                command.Parameters.AddWithValue("@soLuong", soLuong);
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
        public static DataSet getAllChiTietHoaDon()
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from ChiTietHoaDon";

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
        public static DataSet getAllChiTietHoaDon(int idHoaDon)
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from ChiTietHoaDon where idHoaDon = @idHoaDon";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@idHoaDon", idHoaDon);

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
        public static void deleteChiTietHoaDon(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "delete from ChiTietHoaDon where id = @id";
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

        public static void updateChiTietHoaDon(int id, int idHoaDon, int idMatHang, int soLuong, double donGia)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "update ChiTietHoaDon set idHoaDon = @idHoaDon, idMatHang = @idMatHang, " +
                        "soLuong = @soLuong, donGia = @donGia where id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                    command.Parameters.AddWithValue("@idMatHang", idMatHang);
                    command.Parameters.AddWithValue("@soLuong", soLuong);
                    command.Parameters.AddWithValue("@donGia", donGia);                    

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
