using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeeDashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            // CreateDefaultBuilder() performs
            //1. Setting up the web server
            //2. loading the host config and app config
            //3. config logging
            //To configure InProcess hosting CreateDefaultBuilder() method calls UseIIS()
            //method and host the app inside of the IIS worker process (w3wp.exe or iisexpress.exe(defult))
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
