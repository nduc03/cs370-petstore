using System.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace petstore
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>(option =>
            {
                if (IsPostgresDb(ConfigurationManager.AppSettings.Get("dbType")))
                    option.UseNpgsql(
                        "Host=localhost;Port=5432;Database=cs370_petstore;Username=postgres;Password=1234"
                    );
                else
                    option.UseSqlite("Data Source=petstore.db");
            });
            services.AddScoped<LoginForm>();
            services.AddScoped<AdminPageFormFactory>();
            services.AddScoped<UserPageFormFactory>();
            services.AddScoped<PetStoreFormFactory>();
            services.AddScoped<PetStoreService>();

            using var serviceProvider = services.BuildServiceProvider();

            try
            {
                var dbContext = serviceProvider.GetRequiredService<AppDbContext>();
                Utils.InitializeDb(dbContext);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Database setup failed: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var mainForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(mainForm);
        }

        private static bool IsPostgresDb(string? dbName)
        {
            if (string.IsNullOrEmpty(dbName))
                return false;
            var normalized = dbName.Trim().ToLower();
            return normalized == "postgres" || normalized == "postgresql";
        }
    }
}