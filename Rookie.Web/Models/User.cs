using Rookie.Web.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rookie.Web.Models
{
    public class User: IdentityUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? ImgID { get; set; }
        public string UserEmail { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("AddressID")]
        public int AddressID { get; set; }
        public Address User_Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
