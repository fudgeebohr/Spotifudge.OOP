using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifudgeOOP
{
    class User
    {
        public string Username { get; private set; }

        public User(string username)
        {
            Username = username;
        }
    }
}    
