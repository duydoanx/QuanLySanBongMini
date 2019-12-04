using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class PhieuDatSanBongDAO
    {
        public static void addPhieuDatSanBong(int idSanBong, DateTime thoiGianBatDau, int soGioDat, double donGia, int idHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();
                
                String query = "insert into PhieuDatSanBong(idSanBong, thoiGianBatDau, soGioDat, donGia, idHoaDon) " +
                       "values (@idSanBong, @thoiGianBatDau, @soGioDat, @donGia, @idHoaDon);";               
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@idSanBong", idSanBong);
                command.Parameters.AddWithValue("@thoiGianBatDau", thoiGianBatDau);
                command.Parameters.AddWithValue("@soGioDat", soGioDat);
                command.Parameters.AddWithValue("@donGia", donGia);
                command.Parameters.AddWithValue("@idHoaDon", idHoaDon);

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
        public static DataSet getAllPhieuDatSanBong(int idSanBong)
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from PhieuDatSanBong where idSanBong = @idSanBong";

                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.AddWithValue("@idSanBong", idSanBong);

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
        public static DataSet getAllPhieuDatSanBong()
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from PhieuDatSanBong";                    

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
        public static void deletePhieuDatSanBong(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "delete from PhieuDatSanBong where id = @id";
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
        public static void updatePhieuDatSanBong(int id, int idSanBong, DateTime thoiGianBatDau, int soGioDat, double donGia,
            int idHoaDon)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "update PhieuDatSanBong set idSanBong = @idSanBong, thoiGianBatDau = @thoiGianBatDau, " +
                        "soGioDat = @soGioDat, donGia = @donGia, idHoaDon = @idHoaDon where id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@thoiGianBatDau", thoiGianBatDau);
                    command.Parameters.AddWithValue("@soGioDat", soGioDat);
                    command.Parameters.AddWithValue("@donGia", donGia);
                    command.Parameters.AddWithValue("@idHoaDon", idHoaDon);
                    command.Parameters.AddWithValue("@idSanBong", idSanBong);

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
