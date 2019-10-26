using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DAO
{
    public class SQLConnection
    {
        String sqlConnectStr = "Data Source=localhost;Initial Catalog=sanbong;Persist Security Info=True;User ID=sanbong_admin;Password=1230456";
        SqlConnection connection;

        public SQLConnection()
        {
            connection = new SqlConnection(sqlConnectStr);
        }
        public SqlConnection openConnect()
        {
            connection.Open();
            return connection;
        }
        
        public void closeConnect()
        {
            connection.Close();
        }
    }
}
