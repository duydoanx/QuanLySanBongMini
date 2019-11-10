using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAO;
using System.Data.SqlClient;

namespace BUS
{
    public class UserBUS
    {
        public static bool isExist(String username, String password)
        {
            try
            {
                if (UserDAO.getUser(username, password) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public static User getUser(String username, String password)
        {
            if (isExist(username, password))
            {
                return UserDAO.getUser(username, password);
            }
            else
            {
                return null;
            }
        }
    }
}
