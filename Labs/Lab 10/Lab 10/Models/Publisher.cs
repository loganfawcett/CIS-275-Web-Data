using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_10.Models
{
    public class Publisher
    {
        public int PublisherID { get; set; }
        public string PublisherName { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}