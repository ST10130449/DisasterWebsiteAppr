using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
