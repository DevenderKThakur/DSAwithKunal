using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Book
    {
        public String title;
        public String author;
        public int pages;

        public Book(String aTitle , String aAuthor , int aPages ) { // this is a constructor for the class Book . Constructor is a special method that is inside a class.
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
