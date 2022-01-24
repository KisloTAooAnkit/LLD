using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    abstract class User
    {
        private int id;
        private string name;
        private string address;
        private string username;
        private string password;

        public string getName { get { return name; } }
        public string getAddress { get { return address; } }

        //phone password ek baat man rha abhi ke liye
        public string getPassword {  get { return password; } }

        public void setUser(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
