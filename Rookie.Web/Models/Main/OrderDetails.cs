using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class OrderDetails
    {
        public int Order_detail_ID { get; set; }
        public Order OrderID { get; set; }
        public User UserID { get; set; }
        public Product ProductID { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public Address AddressID { get; set; }
        public List<Product> Order_detail_prod { get; set; }
    }
}
