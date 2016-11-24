using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class SearchViewModel
    {
        public Games Games { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public List<string> Genre { get; set; }
        public int? Quantity { get; set; }

    }
}