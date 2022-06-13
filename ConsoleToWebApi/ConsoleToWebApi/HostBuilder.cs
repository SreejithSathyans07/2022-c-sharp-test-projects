namespace ConsoleToWebApi
{
    public class HostBuilder
    {
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureWebHostDefaults(webhost =>
            {
                webhost.UseStartup<Startup>();
            });
        }
    }
}
