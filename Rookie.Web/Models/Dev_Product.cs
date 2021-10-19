using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Dev_Product
    {
        public int devID { get; set; }
        public Dev Dev { get; set; }
        public int productID { get; set; }
        public Product product { get; set; }

    }
}
