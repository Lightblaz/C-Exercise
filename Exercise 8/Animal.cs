using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_8
{
    class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.name = name;
        }


        public virtual string toString()
        {
            string text = "Animal: Animal[name =" + name + "]";
            return text;
        }
    }
}
