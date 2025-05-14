using Microsoft.Extensions.DependencyInjection;

namespace petstore
{
    public partial class AdminPageForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly IServiceProvider serviceProvider;
        private readonly User loggedInUser;
        public AdminPageForm(AppDbContext dbCtx, IServiceProvider serviceProvider, User loggedInUser)
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            this.serviceProvider = serviceProvider;
            this.loggedInUser = loggedInUser;
            if (!loggedInUser.IsAdmin)
                throw new ArgumentException("User is not admin, cannot access admin page.");
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            var pet = new Pet
            {
                Name = txtPetName.Text,
                Type = txtPetType.Text,
                Price = decimal.ToDouble(numPetPrice.Value),
                ImageUri = txtPetPictureUri.Text
            };
            dbCtx.Pets.Add(pet);
            dbCtx.SaveChanges();

            txtPetName.Text = string.Empty;
            txtPetType.Text = string.Empty;
            numPetPrice.Value = 0;
            txtPetPictureUri.Text = string.Empty;
            MessageBox.Show("Pet added successfully.");
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {
            var petStoreFormFactory = serviceProvider.GetRequiredService<PetStoreFormFactory>();
            var storeForm = petStoreFormFactory.Create(loggedInUser, this);
            storeForm.Show();
        }
    }

    public class AdminPageFormFactory(IServiceProvider serviceProvider)
    {
        private readonly IServiceProvider serviceProvider = serviceProvider;
        public AdminPageForm Create(User loggedInUser)
        {
            var dbCtx = serviceProvider.GetRequiredService<AppDbContext>();
            return new AdminPageForm(dbCtx, serviceProvider, loggedInUser);
        }
    }
}