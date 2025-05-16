namespace petstore
{

    public class PetStoreService(AppDbContext dbCtx)
    {
        public Status Adopt(int userId, int petId)
        {
            var user = dbCtx.Users.FirstOrDefault(u => u.Id == userId);
            var pet = dbCtx.Pets.FirstOrDefault(p => p.Id == petId);
            if (user == null)
            {
                return new Status(false, "User not found");
            }
            if (pet == null)
            {
                return new Status(false, "Pet not found");
            }
            if (user.IsAdmin)
            {
                return new Status(false, "Admin cannot adopt pets");
            }
            if (pet.AdoptedBy != null)
            {
                return new Status(false, "Pet already adopted");
            }
            if (user.Balance < pet.Price)
            {
                return new Status(false, "Not enough balance");
            }
            user.Balance -= pet.Price;
            pet.AdoptedBy = user;
            dbCtx.SaveChanges();
            return new Status(true, "Adopted successfully");
        }

        public Status AddNewPet(int userId, Pet petToAdd)
        {
            var user = dbCtx.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
            {
                return new Status(false, "User not found");
            }
            if (!user.IsAdmin)
            {
                return new Status(false, "You don't have permission. Only admin can add pets");
            }
            if (string.IsNullOrEmpty(petToAdd.Name) || string.IsNullOrEmpty(petToAdd.Type) || petToAdd.Price < 0)
            {
                return new Status(false, "Invalid pet data");
            }
            string picUri;
            try
            {
                picUri = Utils.NormalizeUri(petToAdd.ImageUri);
            }
            catch (UriFormatException)
            {
                return new Status(false, "Invalid image URI");
            }
            petToAdd.ImageUri = picUri;
            dbCtx.Pets.Add(petToAdd);
            dbCtx.SaveChanges();
            return new Status(true, "Pet added successfully");
        }

        public Status RemovePet(int userId, int petToRemoveId)
        {
            var user = dbCtx.Users.FirstOrDefault(u => u.Id == userId);
            var pet = dbCtx.Pets.FirstOrDefault(p => p.Id == petToRemoveId);
            if (user == null)
            {
                return new Status(false, "User not found");
            }
            if (!user.IsAdmin)
            {
                return new Status(false, "You don't have permission. Only admin can remove pets in store.");
            }
            if (pet == null)
            {
                return new Status(false, "Pet not found");
            }
            if (pet.AdoptedBy != null)
            {
                return new Status(false, "Pet already adopted. Cannot remove adopted pets.");
            }
            dbCtx.Pets.Remove(pet);
            dbCtx.SaveChanges();
            return new Status(true, "Pet removed successfully");
        }
    }
}
