using Microsoft.EntityFrameworkCore;

namespace petstore
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    IsAdmin = true,
                },
                new User
                {
                    Id = 2,
                    Username = "user",
                    Password = "1234",
                    IsAdmin = false,
                }
            );
        }
    }
}
