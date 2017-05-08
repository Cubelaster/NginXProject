using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace NginXProject
{
    /// <summary>
    /// Executing the "dotnet run command in the application folder will run this app.
    /// </summary>
    public class Program
    {
        public static string Server;

        // The default listening address is http://localhost:5000 if none is specified.
        // Replace "localhost" with "*" to listen to external requests.
        // You can use the --urls command-line flag to change the listening address. Ex:
        // > dotnet run --urls http://*:8080;http://*:8081

        // Use the following code to configure URLs in code:
        // builder.UseUrls("http://*:8080", "http://*:8081");
        // Put it after UseConfiguration(config) to take precedence over command-line configuration.

        public static void Main(string[] args)
        {
            Console.WriteLine("Running demo with Kestrel.");

            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("hosting.json", optional: true)
            //    .Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                //.UseConfiguration(config)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5200", "https://localhost:5201")
                //.UseIISIntegration()
                .Build();

            host.Run();
        }
    }
}
