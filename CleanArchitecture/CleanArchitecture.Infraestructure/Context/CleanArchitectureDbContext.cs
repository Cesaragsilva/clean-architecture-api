using CleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infraestructure.Context
{
    public class CleanArchitectureDbContext : DbContext
    {
        public CleanArchitectureDbContext(DbContextOptions<CleanArchitectureDbContext> options) : base(options) { }
        public DbSet<Car> Car { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Car>()
                .Property(x => x.Name)
                .IsRequired();

            builder.Entity<Car>()
                .Property(x => x.Model)
                .IsRequired();

            builder.Entity<Car>()
                .Property(x => x.IsActive)
                .IsRequired();

            builder.Entity<Car>()
                .Property(x => x.CreatedAt)
                .IsRequired();
        }
    }
}
