using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using DbhVpnClient.Inferstructure;

namespace DbhVpnClient.App
{
    internal class Program
    {

        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .Build();

            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddInferstructure(config);
            services.AddScoped<MainForm>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}