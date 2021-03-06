﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price;
            }
            protected set
            {
                base.Price = value * (decimal)1.3;
            }
        }
    }
}
