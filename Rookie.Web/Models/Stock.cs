using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Stock
    {
        [Key]
        public int stockID { get; set; }
        public Product productID { get; set; }
        public int in_quantity { get; set; }
        public int out_quantity { get; set; }
        public DateTime add_date { get; set; }
        public List<Product> product { get; set; } 
    }
}
