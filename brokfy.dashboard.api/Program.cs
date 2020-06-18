using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace brokfy.dashboard.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            //.UseKestrel(options =>
            //{
            //    //options.Listen(IPAddress.Parse("172.31.37.243"), 5000);
            //    options.Listen(IPAddress.Loopback, 4300, listenOptions =>
            //    {
            //        listenOptions.UseHttps("server.p12", "Brokfy2020");
            //    });
            //})
            .UseKestrel(option => 
            { 
                option.Listen(IPAddress.Any, 4300, listenOptions => { listenOptions.UseHttps("server.p12", "Brokfy2020"); }); 
            })
            .UseUrls("https://ec2-3-136-94-107.us-east-2.compute.amazonaws.com:4300")
            .UseStartup<Startup>();
    }
}
