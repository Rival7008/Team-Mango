using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    internal class LogIn
    {
        private int _id;
        private string _username;
        private string _password;

        public int ID { get { return _id; } set { _id = value; } }
        public string UserName { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }


        public int Login()
        {
            return 0;
        }
    }
}
