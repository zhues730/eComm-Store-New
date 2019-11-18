using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eComm_Store.Models
{
    public class Users
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public Cart cart;

    }
}