using Microsoft.EntityFrameworkCore;

namespace petstore.Services
{
    public class UserService(AppDbContext dbCtx)
    {
        public Status<List<Pet>> GetAdoptedPets(int userId)
        {
            var user = dbCtx.Users.Include(u => u.AdoptedPets).FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return new Status<List<Pet>>(false, "User not found", null);
            }
            return new Status<List<Pet>>(true, "Success", user.AdoptedPets);
        }

        public Status AddBalance(int userId, double amount)
        {
            var user = dbCtx.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return new Status(false, "User not found");
            }
            if (amount < 0)
            {
                return new Status(false, "Added amount cannot be negative");
            }
            user.Balance += amount;
            dbCtx.SaveChanges();
            return new Status(true, "Balance added successfully");
        }

        public Status<double> GetBalance(int userId)
        {
            var user = dbCtx.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return new Status<double>(false, "User not found", 0);
            }
            return new Status<double>(true, "Success", user.Balance);
        }
    }
}
