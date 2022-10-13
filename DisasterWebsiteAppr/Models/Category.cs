using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Models
{
    public class Category
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public virtual ICollection<Disaster> Disasters { get; set; }       
        public virtual ICollection<Donation> Donations { get; set; }       
    }
}
