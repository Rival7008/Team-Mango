using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    internal class User
    {
        private int _id;
        public string Name;
        private string _username;
        private string _password;
        public decimal _currency;
        public int ID { get { return _id; } set { _id = value; } }
        public string UserName { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public decimal Currency { get { return _currency; } set { _currency = value; } }




    }
}
