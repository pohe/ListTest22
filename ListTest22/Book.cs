using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest22
{
    public class Book
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }

        public Book(string titel, string author, string isbn)
        {
            Title = titel;
            Author = author;
            Isbn = isbn;
        }


        public override string ToString()
        {
            return $"{Title} {Author} {Isbn}";
        }
    }
}
