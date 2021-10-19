using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rookie.Web.Data;

namespace Rookie.Web.Models
{
    public class Stock: BaseEntity
    {
        public int StockID { get; set; }
        public int In_quantity { get; set; }
        public int Out_quantity { get; set; }
        public DateTime Add_date { get; set; }
        public ICollection<Product> Stock_Product { get; set; } 
    }

    public class StockMapping
    {
        public StockMapping(EntityTypeBuilder<Stock> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(s => s.Id);
            entityTypeBuilder.Property(s => s.StockID);
            entityTypeBuilder.Property(s => s.In_quantity);
            entityTypeBuilder.Property(s => s.Out_quantity);
            entityTypeBuilder.Property(s => s.Add_date);
            entityTypeBuilder.HasOne(s => s.Stock_Product).WithMany(s => s.Product_stock)
        }
    }
}
