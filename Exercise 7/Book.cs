using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_7
{
    class Book
    {
        private string isbn;
        private string name;
        private Author author = new Author("" ,"");
        private double price;
        private int qty;

        public Book(string isbn  , string name , string aname , string email , double price)
        {
            this.isbn = isbn;
            this.name = name;
            this.author.setName(aname);
            this.author.setEmail(email);
            this.price = price;
        }

       /* public Book(string isbn, string name, Author author, double price, int qty) : this(isbn, name, author, price)
        {
            this.qty = qty;
        }*/

        public string getISBN()
        {
            return isbn;
        }

        public string getName()
        {
            return name;
        }

        public Author getAuthor()
        {
            return author;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQty()
        {
            return qty;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public string getAuthorName()
        {
            return author.getName();
        }

        public override string ToString()
        {
            string text = "Book[isbn= " + isbn + " , name = " + name + "  , " + base.ToString() + " , price = " + price + "  , qty= " + qty + " ]";
            return text;
        }
    }
}
