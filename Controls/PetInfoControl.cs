namespace petstore
{
    public partial class PetInfoControl : UserControl
    {
        private readonly int petId;
        public int PetId { get => petId; }
        public PetInfoControl(int petId)
        {
            InitializeComponent();
            this.petId = petId;
        }
    }
}
