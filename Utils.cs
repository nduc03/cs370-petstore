using System.Configuration;

using Microsoft.EntityFrameworkCore;

namespace petstore
{
    public static class Utils
    {
        private static readonly HttpClient httpClient;
        private static int imageFailCount = 0;

        static Utils()
        {
            var handler = new SocketsHttpHandler
            {
                PooledConnectionLifetime = TimeSpan.FromMinutes(5),
            };
            httpClient = new HttpClient(handler, disposeHandler: false);
        }

        public static void InitializeDb(DbContext dbCtx)
        {
            if (ConfigurationManager.AppSettings.Get("resetDb") == "1")
            {
                var accept = MessageBox.Show(
                    "App.config are setting resetDb to 1. Reset the database?", 
                    "Reset Database", 
                    MessageBoxButtons.YesNo
                );
                if (accept == DialogResult.Yes)
                {
                    dbCtx.Database.EnsureDeleted();
                }
                else
                {
                    MessageBox.Show("Database reset cancelled.");
                }
            }

            dbCtx.Database.EnsureCreated();
        }

        public static PetInfoControl Pet2PetControl(Pet pet)
        {
            var petControl = new PetInfoControl(pet.Id);
            _ = LoadImageFromUriAsync(petControl.picture, pet.ImageUri);
            petControl.name.Text = "Name: " + pet.Name;
            petControl.type.Text = "Type: " + pet.Type;
            petControl.price.Text = "Price: " + pet.Price.ToString();
            return petControl;
        }

        public static async Task LoadImageFromUriAsync(PictureBox pictureBox, string uri)
        {
            try
            {
                if (uri.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(uri);
                    using var ms = new MemoryStream(imageBytes);
                    pictureBox.Image = Image.FromStream(ms);
                }
                else if (uri.StartsWith("file://", StringComparison.OrdinalIgnoreCase))
                {
                    var localPath = new Uri(uri).LocalPath;
                    pictureBox.Image = Image.FromFile(localPath);
                }
                else
                {
                    // Fallback: raw path
                    pictureBox.Image = Image.FromFile(uri);
                }
            }
            catch
            {
                if (imageFailCount == 0) 
                    MessageBox.Show("Failed to some images.");
                imageFailCount++;
                SetTimeout(() =>
                {
                    imageFailCount = 0;
                }, 6000);
            }
        }

        public static string NormalizeUri(string input)
        {
            var output = input.Trim().Trim('"');
            output = new Uri(output).ToString();
            return output;
        }

        public static void SetTimeout(Action action, int timeoutMs)
        {
            var timer = new System.Timers.Timer(timeoutMs);
            timer.Elapsed += (s, e) =>
            {
                action();
            };
            timer.AutoReset = false;
            timer.Start();
        }
    }
}
