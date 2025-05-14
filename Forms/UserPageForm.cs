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
            this.loggedInUser = loggedInUser;
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {
            var petStoreFormFactory = serviceProvider.GetRequiredService<PetStoreFormFactory>();
            var storeForm = petStoreFormFactory.Create(loggedInUser, this);
            storeForm.Show();
        }

        private void LoadUserInfo()
        {
            // TODO
        }
    }

    public class UserPageFormFactory(IServiceProvider serviceProvider)
    {
        private readonly IServiceProvider serviceProvider = serviceProvider;

        public UserPageForm Create(User loggedInUser)
        {
            var dbCtx = serviceProvider.GetRequiredService<AppDbContext>();
            return new UserPageForm(dbCtx, serviceProvider, loggedInUser);
        }
    }
}