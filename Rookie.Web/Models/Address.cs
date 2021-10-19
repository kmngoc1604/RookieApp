using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Address
    {
        [Key]
        public int addressID { get; set; }
        public User userID { get; set; }
        public Order orderID { get; set; }
        public string location { get; set; }
    }
}
