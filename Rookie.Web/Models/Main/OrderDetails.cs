using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class OrderDetails
    {
        public int order_detail_ID { get; set; }
        public Order orderID { get; set; }
        public User userID { get; set; }
        public Product productID { get; set; }
        public int quantity { get; set; }
        public struct note { get; set; }
        public Address addressID { get; set; }
        public List<Product> orderdeprod { get; set; }
    }
}
