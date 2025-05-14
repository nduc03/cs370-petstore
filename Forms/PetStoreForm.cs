using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace petstore
{
    public partial class PetStoreForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly User loggedInUser;
        public PetStoreForm(AppDbContext dbCtx, User loggedInUser)
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            this.loggedInUser = loggedInUser;
            Text = loggedInUser.Username;

            //Load += async (_, e) => OnLoadAsync(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            dbCtx.Pets.Load();
            UpdatePetList();
        }

        private void UpdatePetList()
        {
            listPetPanel.Controls.Clear();
            foreach (var pet in dbCtx.Pets)
            {
                listPetPanel.Controls.Add(Pet2PetControl(pet));
            }
        }

        private static PetInfoControl Pet2PetControl(Pet pet)
        {
            var petControl = new PetInfoControl(pet.Id);
            _ = Utils.LoadImageFromUriAsync(petControl.picture, pet.ImageUri);
            petControl.name.Text = "Name: " + pet.Name;
            petControl.type.Text = "Type: " + pet.Type;
            petControl.price.Text = "Price: " + pet.Price.ToString();
            petControl.BorderStyle = BorderStyle.FixedSingle;
            return petControl;
        }

        private void reload_Click(object sender, EventArgs e)
        {
            UpdatePetList();
        }
    }

    public class PetStoreFormFactory(IServiceProvider serviceProvider)
    {
        private readonly IServiceProvider serviceProvider = serviceProvider;
        public PetStoreForm Create(User loggedInUser, Form owner)
        {
            var dbCtx = serviceProvider.GetRequiredService<AppDbContext>();
            return new PetStoreForm(dbCtx, loggedInUser) { Owner = owner };
        }
    }
}
