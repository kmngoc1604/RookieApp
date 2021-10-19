using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Role
    {
        [Key]
        public int roleID { get; set; }
        public string role { get; set; }
        public List<User> userRole { get; set; }
    }
}
