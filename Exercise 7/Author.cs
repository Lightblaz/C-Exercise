using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_7
{
    class Author
    {
        private string name;
        private string email;

        //functions

        public Author(string name , string email)
        {
            this.name = name;
            this.email = email;
        }

        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email) 
        {
            this.email = email;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public virtual void ToString()
        {
            Console.WriteLine("Author[name= " + name + " , email= " + email + "]");
        }
    }
}
