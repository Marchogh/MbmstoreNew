using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product 
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }
        public Book () { }

        public Book(string title, string author, string publisher, short published, string isbn, decimal price, string imageUrl, int productId) : 
            base (title, price, imageUrl, productId)
        {
            Author = author;
            Publisher = publisher;
            Published = published;
            ISBN = isbn;
        }
    }
}