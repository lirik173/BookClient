using System;
using System.Collections.Generic;
using System.Text;

namespace BookClient.Models
{
    public class Book
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
    }
}
