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
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> PublisedProducts { get; set; }
    }
}
