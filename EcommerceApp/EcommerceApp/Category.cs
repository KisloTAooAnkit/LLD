using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceApp
{
    class Category
    {
        private string name;
        private string description;

        public string getName
        {
            get { return name; }
        }

        public Category(string name)
        {
            this.name = name;
        }
    }
}
