using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Order
    {
        [Key]
        public int orderID { get; set; }
        public User userID { get; set; }
        public string shipping { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public Product productID { get; set; }
        public List<Product> orderproduct { get; set; }
    }
}
