using Rookie.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rookie.Web.Models
{
    public class Genre:BaseEntity
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public string Description { get; set; }
        
        //Product
        [ForeignKey("productID")]
        public int productID { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> GenreProducts { get; set; }
    }
    public class GenreMapping
    {
        public GenreMapping(EntityTypeBuilder<Genre> entityTypeBuilder)
        {
            entityTypeBuilder.HasOne(gen => gen.Product).WithMany(gen => gen.ProductGenre).HasForeignKey(gen => gen.productID);
        }
    }
}
