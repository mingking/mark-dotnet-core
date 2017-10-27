using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace dotnet_core_me
{
    public class Program
    {
        public static void Main(string[] args)
        {
/*
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
*/

            /*
            //refer to :http://kerryritter.com/deploying-asp-net-core-to-heroku/
            var url = $"http://*:{Environment.GetEnvironmentVariable("PORT")}/";
            Console.WriteLine($"Using Url: {url}");

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(url)
                .Build();
            */

            //refer to :http://codersblock.com/blog/how-to-run-net-on-heroku/
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseConfiguration(config)
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
