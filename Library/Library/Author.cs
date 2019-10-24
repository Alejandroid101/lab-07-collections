using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Author
    {
        public string FirstNAme { get; set; }
        public string LastName { get; set; }
        public Author(string firstname, string lastname)
        {
            FirstNAme = firstname;
            LastName = lastname;
        }
    }
}
