using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_10.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public int PublisherID { get; set; }
        public decimal Price { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}