using System;
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
            this._id = id;
            this._username = Username;
            this._password = Password;
        }
        
        public override string ToString()
        {
            return $"Id: {_id}\nName: {_username}\nPassword: {_password}";
        }
    }
}
