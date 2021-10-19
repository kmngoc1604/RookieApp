using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Web.Models
{
    public class Role: IdentityRole
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
