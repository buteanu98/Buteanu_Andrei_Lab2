using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buteanu_Andrei_Lab2.Models.LibraryViewModel
{
    public class PublisherIndexData
    {
        public IEnumerable<Publishers> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
