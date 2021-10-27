using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Rating
    {
        [Key]
        public int rating { get; set; }
        public User userID { get; set; }
        public Product productID { get; set; }
        public string comment { get; set; }
    }
}
