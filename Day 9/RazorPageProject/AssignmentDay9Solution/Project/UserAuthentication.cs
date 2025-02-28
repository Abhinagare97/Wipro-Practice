using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class UserAuthentication
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Register(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool Authenticate(string username, string password)
        {
            if (username == Username && password == Password)
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
