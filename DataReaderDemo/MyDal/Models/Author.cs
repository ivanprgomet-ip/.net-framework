﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDal
{
    public class Author
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int AuthorID { get; set; }

        public Author()
        {

        }
        public Author(int authorID, string firstname, string lastname)
        {
            AuthorID = authorID;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
