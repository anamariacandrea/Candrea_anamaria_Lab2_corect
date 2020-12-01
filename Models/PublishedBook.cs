using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Candrea_anamaria_Lab2.Models
{
    public class PublishedBook
    {
        public int PublisherID { get; set; }
        public int BookID { get; set; }
        public Publishers Publisher { get; set; }
        public Book Book { get; set; }
    }
}
