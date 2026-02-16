using Kiss_Milan_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Kiss_Milan_backend.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<ingatlanok> ingatlanoks { get; set; }
        public DbSet<kategoriak> kategoriaks { get; set; }
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ingatlanok>()
                .Property(i => i.hirdetesDatuma)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
