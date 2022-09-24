using LW_2_Core.Configuration;
using LW_2_Core.Interfces;
using LW_2_Core.ruGPT_3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace LW_2_App
{

    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        private IConfiguration _configuration;
        public App()
        {

            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();

            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<ITextGenerator, ruGPT_3_TextGenerator>();
            services.Configure<ruGPT_3_Configuration>(_configuration.GetSection("Generation:ruGPT_3"));
            services.AddSingleton<TextGeneration>();
        }

        protected void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<TextGeneration>();
            mainWindow.Show();
        }
    }
}
