using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eComm_Store.Models
{
    public class Cart
    {
        public int id { get; set; }
        public List<Products> Items { get; set; }
        public double TotalPrice { get; set; }


    }
}