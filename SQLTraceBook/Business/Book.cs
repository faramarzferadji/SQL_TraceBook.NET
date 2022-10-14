using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTraceBook.Business
{
   public class Book
    {
        public int Block { get; set; }
        public string StName { get; set; }
        public string Titel { get; set; }
        public string BookId { get; set; }
        public DateTime Dateout { get; set; }
        public DateTime Datedue { get; set; }

    }
}
