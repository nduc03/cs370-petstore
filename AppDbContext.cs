using Microsoft.EntityFrameworkCore;

namespace petstore
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.AdoptedPets)
                .WithOne(e => e.AdoptedBy);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = -1,
                    Username = "admin",
                    Password = "admin",
                    IsAdmin = true,
                },
                new User
                {
                    Id = -2,
                    Username = "user",
                    Password = "1234",
                    IsAdmin = false,
                }
            );
#if DEBUG
            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = -1,
                    Name = "test",
                    Type = "test",
                    Price = 1000.0,
                    ImageUri = "https://picsum.photos/200",
                    //AdoptedBy = null,
                },
                new Pet
                {
                    Id = -2,
                    Name = "test2",
                    Type = "test2",
                    Price = 2000.0,
                    ImageUri = "https://picsum.photos/200",
                    //AdoptedBy = null,
                }
            );
#endif
        }
    }
}
