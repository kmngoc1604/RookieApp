using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rookie.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Product:BaseEntity
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductURL { get; set; }
        public string Description { get; set; }
        public DateTime Created_date { get; set; }
        public DateTime Published_date { get; set; }
        public DateTime Updated_date { get; set; }
        public List<Rating> Rating { get; set; }

        //Category
        public int CategoriesID { get; set; }
        public Category Categories { get; set; }

        //Publisher
        public int PublisherID { get; set; }
        public Publisher Publishers { get; set; }

        //Genre
        public int GenreID { get; set; }
        public Genre Genres { get; set; }
        public ICollection<Genre> ProductGenre { get; set; }

        //Dev
        public int DevID { get; set; }
        public Dev Dev { get; set; }

        //Stock
        public int StockID { get; set; }
        public Stock Stock { get; set; }

        //Prod Image
        public ICollection<ProductImage> ProdImages { get; set; }
    }

    public class ProdMapping
    {
        public ProdMapping(EntityTypeBuilder<Product> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(prod => prod.Id);
            entityTypeBuilder.Property(prod => prod.ProductName).HasMaxLength(200);
            entityTypeBuilder.Property(prod => prod.ProductURL);
            entityTypeBuilder.Property(prod => prod.Description).HasMaxLength(200);
            entityTypeBuilder.Property(prod => prod.Created_date);
            entityTypeBuilder.Property(prod => prod.Published_date);
            entityTypeBuilder.Property(prod => prod.Updated_date);
            entityTypeBuilder.Property(prod => prod.Rating);
        
            entityTypeBuilder.HasOne(prod => prod.Categories).WithMany(prod => prod.CategoryProducts).HasForeignKey(prod => prod.CategoriesID);
            entityTypeBuilder.HasOne(prod => prod.Publishers).WithMany(prod => prod.PublisedProducts).HasForeignKey(prod => prod.PublisherID);
            entityTypeBuilder.HasOne(prod => prod.Genres).WithMany(prod => prod.GenreProducts).HasForeignKey(prod => prod.GenreID);
            entityTypeBuilder.HasOne(prod => prod.Dev).WithMany(prod => prod.Dev_Product).HasForeignKey(prod => prod.DevID);
        }
    }


}
