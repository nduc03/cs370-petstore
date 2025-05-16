using Microsoft.EntityFrameworkCore;

namespace petstore
{
    public partial class PetStoreForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly PetStoreService petStoreService;
        private readonly User loggedInUser;

        public PetStoreForm(AppDbContext dbCtx, User loggedInUser, PetStoreService petStoreService)
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            this.loggedInUser = loggedInUser;
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
                if (loggedInUser.IsAdmin)
                {
                    SetupRemovePetButton(petControl.btnAdopt, () => RemovePet(pet));
                }
                else
                {
                    SetupAdoptButton(petControl.btnAdopt, () => AdoptPet(pet));
                }
                listPetPanel.Controls.Add(petControl);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            UpdatePetList();
        }

        private void AdoptPet(Pet adoptee)
        {
            var adopterId = loggedInUser.Id;
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

        private void RemovePet(Pet adoptee)
        {
            var adopterId = loggedInUser.Id;
            var status = petStoreService.RemovePet(adopterId, adoptee.Id);
            if (status.Success)
            {
                MessageBox.Show(status.Message, "Success");
            }
            else
            {
                MessageBox.Show(status.Message, "Error");
            }
        }

        private void SetupAdoptButton(Button button, Action adoptAction)
        {
            button.Enabled = true;
            button.Visible = true;
            button.Click += (s, e) =>
            {
                // TODO change to better confirmation window
                if (MessageBox.Show("Adopt this pet?", "Adopt", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                adoptAction();
                UpdatePetList();
            };
        }

        private void SetupRemovePetButton(Button button, Action removeAction)
        {
            button.Enabled = true;
            button.Visible = true;
            button.Text = "Remove";
            button.Click += (s, e) =>
            {
                // TODO change to better confirmation window
                if (MessageBox.Show("Remove this pet?", "Remove", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                removeAction();
                UpdatePetList();
            };
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
