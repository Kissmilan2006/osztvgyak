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
               new Color { ColorId = 3, Name = "Green" },
               new Color { ColorId = 4, Name = "Yellow" }
               );
            modelBuilder.Entity<Card>().HasData(
                new Card { ColorId = 4, Description = "Awakening of the New Era", ImgUrl = "https://optcgapi.com/media/static/Card_Images/OP05-119.jpg", Name = "Monkey.D.Luffy", Id=1 }
                );
        }
    }
}
