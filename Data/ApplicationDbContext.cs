using Microsoft.EntityFrameworkCore;
using Group_8_Final_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Group_8_Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SalesLeadEntity> SalesLead { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}
