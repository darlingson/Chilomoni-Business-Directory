using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ChilomoniBusinessDirectory.Models;

namespace ChilomoniBusinessDirectory.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
          public DbSet<Business> Businesses { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
