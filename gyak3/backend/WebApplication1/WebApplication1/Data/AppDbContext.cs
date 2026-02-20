using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Color> Colors { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
                   new Card
                   {
                       ColorId = 3,
                       Description = "Awakening of the New Era",
                       ImgUrl = "https://optcgapi.com/media/static/Card_Images/OP05-119.jpg",
                       Name = "Monkey.D.Luffy",
                       Id = 1
                   }
                );
            modelBuilder.Entity<Color>().HasData(
                new Color { Id = 1, Name = "red" },
                new Color { Id = 2, Name = "blue" },
                new Color { Id = 3, Name = "yellow" },
                new Color { Id = 4, Name = "green" }

                );

            modelBuilder.Entity<Card>().Property(i => i.ImgUrl).HasDefaultValue("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR5QnnpQTGXTJUmRbOcpI3mV8QR9sP8OhH4BQ&s");
        }
    }
}
