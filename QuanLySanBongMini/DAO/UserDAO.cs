using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using DTO;
using QuanLySanBongMini.DAO;

namespace DAO
{
    public class UserDAO
    {
        //Lay thong tin doi tuong user tu database
        public static User getUser(String userName, String passWord)
        {
            User user = null;
            //khoi tao ket noi database

            using (SqlConnection conn = new SqlConnection(SQLConnection.connectionString()))
            {
                conn.Open();
                String query = "select * from UserLogin where username = @username and password = @password";
                SqlCommand command = new SqlCommand(query, conn);

                //tao cac parameter
                command.Parameters.AddWithValue("@username", userName);
                command.Parameters.AddWithValue("@password", passWord);

                try
                {
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {

                        String username = (String)dataReader["username"];
                        String password = (String)dataReader["password"];
                        bool isAdmin = (bool)dataReader["isAdmin"];
                        DateTime dateCreate = (DateTime)dataReader["dateCreate"];
                        user = new User(username, password, isAdmin);
                        conn.Close();

                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
                conn.Close();
            }
            return user;
        }
    }
}
