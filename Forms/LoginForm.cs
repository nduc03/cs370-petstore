using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace petstore
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext dbCtx;
        private readonly IServiceProvider serviceProvider;
        public LoginForm(AppDbContext dbCtx, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.dbCtx = dbCtx;
            this.serviceProvider = serviceProvider;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dbCtx.Users.Load();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            var user = dbCtx?.Users.FirstOrDefault(u =>
                u.Username == username && u.Password == password
            );

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            Form? pageForm = user.IsAdmin ?
                serviceProvider.GetRequiredService<AdminPageFormFactory>().Create(user) :
                serviceProvider.GetRequiredService<UserPageFormFactory>().Create(user);

            pageForm.Show();
            pageForm.FormClosed += (s, args) => Show();

            Hide();
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }
            var isExistUser = dbCtx?.Users.Any(u => u.Username == username);

            if (isExistUser == true)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            var newUser = new User
            {
                Username = username,
                Password = password,
                IsAdmin = false
            };
            dbCtx?.Users.Add(newUser);
            dbCtx?.SaveChanges();
            MessageBox.Show("User created successfully. You can now log in.");
        }
    }
}
