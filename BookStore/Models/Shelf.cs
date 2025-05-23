using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Models;

namespace BookStore.Models
{
    class Shelf
    { 
        public List<Book> booklists { get; set; }

        public Shelf(Book b)
        {
            booklists.Add(b);
        }
    }
}
