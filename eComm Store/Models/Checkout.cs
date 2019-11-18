using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eComm_Store.Models
{
    public class Checkout
    {
        public int id { get; set; }
        public Cart cart;
        //billing info from user
        //payment info
        public double GrandTotal { get; set; }
        //user id 
    }
}