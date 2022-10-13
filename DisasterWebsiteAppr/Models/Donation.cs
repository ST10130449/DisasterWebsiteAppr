using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Models
{
    public class Donation
    {
        [Key]
        public int Donationid { get; set; }
        public double Amount { get; set; }
        public double Goods { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }
        public bool isPrivate { get; set; }
        public int DisasterId { get; set; }
        public virtual Disaster Disaster { get; set; }
        public virtual User User { get; set; }
    }
}
