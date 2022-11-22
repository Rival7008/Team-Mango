﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    public class UserAccount
    {
        internal int _id { get; set; }
        internal string _username { get; set; }
        internal string _password { get; set; }

        public UserAccount(int id, string Username, string Password)
        {
            _id = id;
            _username = Username;
            _password = Password;
        }
        
        public override string ToString()
        {
            return $"Id: {_id}\nName: {_username}\nPassword: {_password}";
        }
    }
}
