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
            //khoi tao ket noi database
            SQLConnection connection = new SQLConnection();
            SqlConnection conn = connection.openConnect();
            String query = "select * from UserLogin where username = @username and password = @password";
            SqlCommand command = new SqlCommand(query, conn);

            //tao cac parameter
            command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar, 50);
            command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 50);

            // truyen vao cac parameter
            command.Parameters["@username"].Value = userName;
            command.Parameters["@password"].Value = passWord;

            try
            {
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    int id = (int)dataReader["userID"];
                    String username = (String)dataReader["username"];
                    String password = (String)dataReader["password"];
                    bool isAdmin = (bool)dataReader["isAdmin"];
                    DateTime dateCreate = (DateTime)dataReader["dateCreate"];
                    User user = new User(id, username, password, isAdmin);
                    conn.Close();
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException se)
            {
                throw se;
            }
            
        }
    }
}
