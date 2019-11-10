using System;

namespace DTO
{
    public class User
    {

        public User(string userName, string passWord, bool isAdmin, DateTime dateCreate)
        {
          
            this.userName = userName;
            this.passWord = passWord;
            this.isAdmin = isAdmin;
            this.dateCreate = dateCreate;
        }
        public User(string userName, string passWord, bool isAdmin)
        {
          
            this.userName = userName;
            this.passWord = passWord;
            this.isAdmin = isAdmin;
        }

       
        public String userName { get; set; }
        public String passWord { get; set; }
        public bool isAdmin { get; set; }
        public DateTime dateCreate { get; set; }
        public String toString()
        {
            return " userName: " +userName + ", passWord: " + passWord +
                ", isAdmin: " + isAdmin + ", dateCreate: " + dateCreate;
        }
    }
    
}
