using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eComm_Store.Models
{
    public class Products
    {
        //public int id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}