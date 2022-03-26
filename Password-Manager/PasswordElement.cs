using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Manager
{
    class PasswordElement
    {
        public string _name;
        public string _key;

        public PasswordElement(string str)
        {
            string[] arr = str.Split(" ");

            _name = arr[0];
            _key = arr[1];
        }
    }
}
