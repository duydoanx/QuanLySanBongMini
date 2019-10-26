using System;

namespace DTO
{
    public class User
    {

        public User(int userID, string userName, string passWord, bool isAdmin, DateTime dateCreate)
        {
            this.userID = userID;
            this.userName = userName;
            this.passWord = passWord;
            this.isAdmin = isAdmin;
            this.dateCreate = dateCreate;
        }
        public User(int userID, string userName, string passWord, bool isAdmin)
        {
            this.userID = userID;
            this.userName = userName;
            this.passWord = passWord;
            this.isAdmin = isAdmin;
        }

        public int userID { get; set; }
        public String userName { get; set; }
        public String passWord { get; set; }
        public bool isAdmin { get; set; }
        public DateTime dateCreate { get; set; }
        public String toString()
        {
            return "userID: " + userID + ", userName: " +userName + ", passWord: " + passWord +
                ", isAdmin: " + isAdmin + ", dateCreate: " + dateCreate;
        }
    }
    
}
