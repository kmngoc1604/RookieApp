using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Dev
    {
        [Key]
        public int devID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Dev_Product> Dev_Product { get; set; }
    }
}
