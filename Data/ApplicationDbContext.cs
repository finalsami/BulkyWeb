using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, DisplayOrder = 1, Name = "Action", IsActive = true },
                new Category { Id = 2, DisplayOrder = 1, Name = "SciFi", IsActive = true },
                new Category { Id = 3, DisplayOrder = 1, Name = "History", IsActive = true },
                new Category { Id = 4, DisplayOrder = 1, Name = "War", IsActive = true });
        }
     
    }
}
