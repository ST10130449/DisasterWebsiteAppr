using DisasterWebsiteAppr.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisasterWebsiteAppr.Data
{
    public class AlleviationContext : DbContext
    {
        public AlleviationContext(DbContextOptions<AlleviationContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Disaster> Disasters { get; set; }
        public DbSet<Donation> Donations { get; set; }
    }
}
