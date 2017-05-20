using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using heryerindirim.com.Models;

namespace heryerindirim.com.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<heryerindirim.com.Models.Member> Member { get; set; }

        public DbSet<heryerindirim.com.Models.Campaign> Campaign { get; set; }

        public DbSet<heryerindirim.com.Models.Company> Company { get; set; }

        public DbSet<heryerindirim.com.Models.Product> Product { get; set; }
    }
}
