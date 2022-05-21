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

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }
    }
}