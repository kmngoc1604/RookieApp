using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rookie.Web.Data;

namespace Rookie.Web.Models
{
    public class Category:BaseEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category Categories { get; set; }
        //public ICollection<Category> CategoryList { get; set; }
        public ICollection<Product> CategoryProducts { get; set; }
    }

    public class CategoryMapping
    {
        public CategoryMapping(EntityTypeBuilder<Category> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(cat => cat.Id);
            entityTypeBuilder.Property(cat => cat.Name).HasMaxLength(200);
            entityTypeBuilder.Property(cat => cat.Description).HasMaxLength(200);
            entityTypeBuilder.HasMany(cat => cat.CategoryProducts).WithOne(cat => cat.Categories);
        }
    }


}
