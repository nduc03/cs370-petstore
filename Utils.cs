using System.Configuration;

using Microsoft.EntityFrameworkCore;

namespace petstore
{
    public static class Utils
    {
        private static readonly HttpClient httpClient;

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
                dbCtx.Database.EnsureDeleted();

            dbCtx.Database.EnsureCreated();
        }

        public static async Task LoadImageFromUriAsync(PictureBox pictureBox, string uri)
        {
            try
            {
                if (uri.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                {
                    //using var httpClient = new HttpClient();
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
                    // Fallback: assume it's a raw path
                    pictureBox.Image = Image.FromFile(uri);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}");
            }
        }

    }
}
