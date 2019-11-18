using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eComm_Store.Models
{
    public class Reviews
    {
        public int id { get; set; }
        public Users UserReview { get; set; }
        public string Comment { get; set; }
        
    }
}