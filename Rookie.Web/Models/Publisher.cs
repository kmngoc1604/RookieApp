using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Publisher
    {
        [Key]
        public int publisherID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Product> publisedproducts { get; set; }
    }
}
