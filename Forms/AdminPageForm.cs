using Microsoft.Extensions.DependencyInjection;

namespace petstore
{
    public partial class AdminPageForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly IServiceProvider serviceProvider;
        private readonly User loggedInUser;
        private readonly PetStoreService petStoreService;
        public AdminPageForm(
            AppDbContext dbCtx,
            IServiceProvider serviceProvider,
            User loggedInUser,
            PetStoreService petStoreService
        )
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            this.serviceProvider = serviceProvider;
            this.loggedInUser = loggedInUser;
            this.petStoreService = petStoreService;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!loggedInUser.IsAdmin)
            {
                MessageBox.Show("User is not admin, cannot access admin page.");
                Close();
            }
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
            //dbCtx.Pets.Add(pet);
            //dbCtx.SaveChanges();
            var status = petStoreService.AddNewPet(loggedInUser.Id, pet);

            if (status.Success)
            {
                txtPetName.Text = string.Empty;
                txtPetType.Text = string.Empty;
                numPetPrice.Value = 0;
                txtPetPictureUri.Text = string.Empty;
                MessageBox.Show("Pet added successfully.");
            }
            else
            {
                MessageBox.Show($"Failed to add pet: {status.Message}");
            }
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {
            var petStoreFormFactory = serviceProvider.GetRequiredService<PetStoreFormFactory>();
            var storeForm = petStoreFormFactory.Create(loggedInUser, this);
            storeForm.Show();
        }
    }

    public class AdminPageFormFactory(
        IServiceProvider serviceProvider,
        AppDbContext dbCtx,
        PetStoreService petStoreService
        )
    {
        public AdminPageForm Create(User loggedInUser)
        {
            return new AdminPageForm(dbCtx, serviceProvider, loggedInUser, petStoreService);
        }
    }
}