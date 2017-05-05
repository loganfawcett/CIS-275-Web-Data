using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookDemoApp.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int PublisherID { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}