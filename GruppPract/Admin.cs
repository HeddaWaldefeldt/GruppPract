using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppPract
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Admin()
        {

        }
        public Admin(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool CheckLogin(string username, string password)
        {
            UserName = username;
            Password = password;
            string trueUserName = "Username";
            string truePassword = "Password";

            if (username == trueUserName && password == truePassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
