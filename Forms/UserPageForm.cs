using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace petstore
{
    public partial class UserPageForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly IServiceProvider serviceProvider;
        private readonly User loggedInUser;
        public UserPageForm(AppDbContext dbCtx, IServiceProvider serviceProvider, User loggedInUser)
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            this.serviceProvider = serviceProvider;
            this.loggedInUser = dbCtx.Users
                .Include(u => u.AdoptedPets)
                .FirstOrDefault(u => u.Id == loggedInUser.Id)!;
            VisibleChanged += (s, e) =>
            {
                if (Visible)
                {
                    LoadUserInfo();
                }
            };
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {
            var petStoreFormFactory = serviceProvider.GetRequiredService<PetStoreFormFactory>();
            var storeForm = petStoreFormFactory.Create(loggedInUser, this);
            storeForm.FormClosed += (s, args) => Show();
            storeForm.Show();
            Hide();
        }

        private void LoadUserInfo()
        {
            txtUsername.Text = loggedInUser.Username;
            txtNumPetsOwned.Text = loggedInUser.AdoptedPets.Count.ToString();
            txtCurrentBalance.Text = loggedInUser.Balance.ToString();
            LoadAdoptedPets();
        }

        private void LoadAdoptedPets()
        {
            flowListOwnedPets.Controls.Clear();
            foreach (Pet pet in loggedInUser.AdoptedPets)
            {
                var petControl = Utils.Pet2PetControl(pet);
                flowListOwnedPets.Controls.Add(petControl);
            }
        }

        private void btnSubmitBalance_Click(object sender, EventArgs e)
        {
            loggedInUser.Balance += (double)numAddBalanceAmount.Value;
            dbCtx.SaveChanges();
            MessageBox.Show($"Successfully added {numAddBalanceAmount.Value} to your balance.");
            txtCurrentBalance.Text = loggedInUser.Balance.ToString();
            numAddBalanceAmount.Value = 0;
        }
    }

    public class UserPageFormFactory(IServiceProvider serviceProvider, AppDbContext dbCtx)
    {
        public UserPageForm Create(User loggedInUser)
        {
            return new UserPageForm(dbCtx, serviceProvider, loggedInUser);
        }
    }
}