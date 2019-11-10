using System;

namespace QuanLySanBongMini.DAO
{
    public class SQLConnection
    {
        private static String sqlConnectStr = "Data Source=localhost;Initial Catalog=sanbong;Persist Security Info=True;User ID=sanbong_admin;Password=1230456";
        

        public static String connectionString()
        {
            return sqlConnectStr;
        }
    }
}
