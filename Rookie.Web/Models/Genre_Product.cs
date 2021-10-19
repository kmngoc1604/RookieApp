using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Genre_Product
    {
        public int genreID { get; set; }
        public Genre genre { get; set; }
        public int productID { get; set; }
        public Product product { get; set; }
    }
}
