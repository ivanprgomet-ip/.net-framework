﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Book :IComparable
    {
        public string ISBN;
        public string title;
        public string author;
        public int price;

        public Book(string ISBN, string title, string author, int price)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void Write()
        {
            Console.WriteLine($" {author} - {title} \n Price: {price}:- \n ISBN {ISBN}");
        }
        public int PriceForQuantity(int quantity)
        {
            return price * quantity;
        }

        public int CompareTo(object other)
        {
            /*
                this short line of code is possible because all the simple
                types (eg. int, string) already have implementation for the 
                IComparable interface and are already using the compareto method. 
                Hence, we don't need to do it manually like the commented out 
                piece of code above. 
            */
            Book b = (Book)other;
            return this.ISBN.CompareTo(b.ISBN);

            //this code is not needed due to the simple types already 
            //implementing the IComparable interface and compareto methods
            //if (int.Parse(this.ISBN) > int.Parse(b.ISBN))
            //    return 1;
            //else if (int.Parse(this.ISBN) < int.Parse(b.ISBN))
            //    return -1;
            //else
            //    return 0;
        }


        //when you override equals method, it is also recomended that you 
        //override gethashcode method, othervise the hash codes are not guaranteed 
        //to be unique

        public override bool Equals(object other)
        {
            Book b = (Book)other;
            return this.ISBN.Equals(b.ISBN);
        }
        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode();
        }
    }
}
