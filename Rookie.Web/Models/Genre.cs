using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Genre
    {
        [Key]
        public int genreID { get; set; }
        public string genreName { get; set; }
        public string description { get; set; }
        public List<Product> product { get; set; }
    }
}
