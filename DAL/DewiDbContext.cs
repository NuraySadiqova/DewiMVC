using DewiMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DewiMVC.DAL
{
    public class DewiDbContext:IdentityDbContext <AppUser>
    {
        public DewiDbContext(DbContextOptions<DewiDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
