using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public virtual string Title
        {
            get { return this.title; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public virtual string Author
        {
            get { return this.author; }

            set
            {
                string[] names = value.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (char.IsDigit(names[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }


        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Type: ").Append(this.GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(this.Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(this.Author)
                .Append(Environment.NewLine)
                .Append(String.Format("Price: {0:F2}", this.Price));
           
            return stringBuilder.ToString();
        }

    }
}
