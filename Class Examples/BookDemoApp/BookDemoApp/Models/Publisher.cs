using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BookDemoApp.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        [DisplayName("Publisher")]
        public string PublisherName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}