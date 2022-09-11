using LW_1_App.Models.Enums;
using LW_1_Core;
using LW_1_Core.Azure;
using LW_1_Core.Houndify;
using LW_1_Core.Yandex;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LW_1_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
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
            services.AddTransient<AzureSpechRecognition>();
            services.AddTransient<YandexCloudSpeechRecognition>();
            services.AddTransient<HoundifyRecognition>();
            services.Configure<AzureConfiguration>(_configuration.GetSection("Recognition:Azure"));
            services.Configure<YandexCloudConfiguration>(_configuration.GetSection("Recognition:YandexCloud")); 
            services.Configure<HoundifyConfiguration>(_configuration.GetSection("Recognition:Houndify"));

            services.AddTransient<RecognitionServiceResolver>(serviceProvider => type =>
            {
                switch (type)
                {
                    case RecognizerTypes.Azure:
                        return serviceProvider.GetService<AzureSpechRecognition>();
                    case RecognizerTypes.YandexCloud:
                        return serviceProvider.GetService<YandexCloudSpeechRecognition>();
                    case RecognizerTypes.Houndify:
                        return serviceProvider.GetService<HoundifyRecognition>();
                    default:
                        return serviceProvider.GetService<AzureSpechRecognition>();
                }
            });

            services.AddSingleton<SpeechRecognizerWindow>();
        }

        protected  void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<SpeechRecognizerWindow>();
            mainWindow.Show();
        }
    }
}
