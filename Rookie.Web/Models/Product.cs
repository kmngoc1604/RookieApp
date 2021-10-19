using Rookie.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Product
    {
        [Key]
        public int productID { get; set; }
        public int publisherID { get; set; }
        public int devID { get; set; }
        public int genreID { get; set; }
        public string productName { get; set; }
        public string productURL { get; set; }
        public string description { get; set; }
        public Category category { get; set; }
        public DateTime created_date { get; set; }
        public DateTime published_date { get; set; }
        public DateTime updated_date { get; set; }
        public List<Rating> rating { get; set; }
        public List<Genre_Product> Genre_Products { get; set; }
        public List<Dev_Product> Dev_Product { get; set; }
    }
}
