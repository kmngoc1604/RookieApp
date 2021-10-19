using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class User
    {
        [Key]
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string img { get; set; }
        public string email { get; set; }
        public int roleID { get; set; }
        public List<Role> roleUser { get; set; }
    }
}
