using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rookie.Web.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Rookie.Web.Models
{
    public class ProductImage:BaseEntity
    {
        internal object productName;

        public int ImageID { get; set; }
        public Product ProductID { get; set; }
        public string ImgURL { get; set; }
        public string ImgName { get; set; }
    }

    public class PImapping
    {
        public PImapping(EntityTypeBuilder<ProductImage> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(pi => pi.Id);
            entityTypeBuilder.Property(pi => pi.ImgURL);
            entityTypeBuilder.Property(pi => pi.ImgName);
            entityTypeBuilder.HasOne(pi => pi.ProductID).WithMany(pi => pi.ProdImages).HasForeignKey(pi => pi.ProductID);
        }
    }   
}
