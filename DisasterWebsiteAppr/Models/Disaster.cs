using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Models
{
    public class Disaster
    {
        [Key]
        public int DisasterId { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime Started { get; set; }
        public DateTime Ended { get; set; }
        public double Allocation { get; set; }
        //[ForeignKey("CategoryId")]
        public int CId { get; set; }
        public virtual Category Category { get; set; }
    }
}
