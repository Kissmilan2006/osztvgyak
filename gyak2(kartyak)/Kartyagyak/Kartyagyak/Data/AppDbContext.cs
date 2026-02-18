using Kartyagyak.Models;
using Microsoft.EntityFrameworkCore;

namespace Kartyagyak.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Color> Colors { get; set; }
        public AppDbContext(DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>().HasData(
               new Color { ColorId = 1, Name = "Red" },
               new Color { ColorId = 2, Name = "Blue" },
               new Color { ColorId = 3, Name = "Green" }
               );
        }
    }
}
