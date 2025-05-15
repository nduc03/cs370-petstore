using Microsoft.EntityFrameworkCore;

namespace petstore
{
    public partial class PetStoreForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly PetStoreService petStoreService;
        private readonly int loggedInUserId;

        public PetStoreForm(AppDbContext dbCtx, User loggedInUser, PetStoreService petStoreService)
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            loggedInUserId = loggedInUser.Id;
            this.petStoreService = petStoreService;
            Text = "Pet store. Logged in as: " + loggedInUser.Username;
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
                if (pet.AdoptedBy != null)
                    continue;
                var petControl = Utils.Pet2PetControl(pet);
                petControl.btnAdopt.Enabled = true;
                petControl.btnAdopt.Visible = true;
                petControl.btnAdopt.Click += (s, e) =>
                {
                    // TODO change to better confirmation window
                    if (MessageBox.Show("Adopt this pet?", "Adopt", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                    AdoptPet(pet);
                    UpdatePetList();
                };
                listPetPanel.Controls.Add(petControl);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            UpdatePetList();
        }

        private void AdoptPet(Pet adoptee)
        {
            var adopterId = loggedInUserId;
            var status = petStoreService.Adopt(adopterId, adoptee.Id);
            if (status.Success)
            {
                MessageBox.Show(status.Message, "Success");
            }
            else
            {
                MessageBox.Show(status.Message, "Error");
            }
        }
    }

    public class PetStoreFormFactory(AppDbContext dbCtx,PetStoreService petStoreService)
    {
        public PetStoreForm Create(User loggedInUser, Form owner)
        {
            return new PetStoreForm(dbCtx, loggedInUser, petStoreService) { Owner = owner };
        }
    }
}
