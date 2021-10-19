using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public int userID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dob { get; set; }
    }
}
