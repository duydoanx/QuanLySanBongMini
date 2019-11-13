using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class PhieuNhapHangDAO
    {
        public static void addPhieuNhapHang(int idMatHang, DateTime ngayNhap, int soLuong, float tongTien)
        {
            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();

                String query = "insert into PhieuNhapHang(idMatHang, ngayNhap, soLuong, tongTien) values (@idMatHang, @ngayNhap, @soLuong, @tongTien);";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@idMatHang", idMatHang);
                command.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                command.Parameters.AddWithValue("@soLuong", soLuong);
                command.Parameters.AddWithValue("@tongTien", tongTien);


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

        public static DataSet getAllPhieuNhapHang()
        {
            DataSet dataSet;
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "select * from PhieuNhapHang";

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

        public static void deletePhieuNhapHang(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
                {
                    conn.Open();

                    String query = "delete from PhieuNhapHang where id = @id";
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
    }
}
