using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDashboard.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeDashboard
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddXmlSerializerFormatters(); // adding all MVC services and AddXmlSerializerFormatters() 
                                                            //method allow to send respond data in XML formate. 
                                                            //Note default is json using Joson() method.
            // registering dependency to service
            // registering MockEmployeeRepository to IEmployeeRepository
            // AddSignleton<>() service is created when it is firt requested. Same instance is used for all subsequent requests. 
            // That is why it is called singleton.
            // ++++ IMPORTANT ++++
            // READ AddTransient() and AddScoped() methods.

            services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())  
            {
                app.UseDeveloperExceptionPage();
            }
            /*
            // to change the default index.html or default.html to foo.html
            DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("foo.html");

            
            //app.UseDefaultFiles(); // set application defualt path to index.html or default.html 
                              //or deafult.htm or index.htm
            app.UseDefaultFiles(defaultFilesOptions); // set default home page to foo.html
            app.UseStaticFiles(); // run static html , js , css files
            

            // run mvc files
            // auto set default route
            //app.UseMvcWithDefaultRoute(); // URL pattern: {controller=Home}/{action=Index}/{id?}'

            // manual address routing name as "Conversional Routing"
            /*app.UseMvc(routes => {
                routes.MapRoute("default", "borda/{controller=Home}/{action=Index}/{Id?}"); // ? mark make id optional
            });
            */
            app.UseMvc();
           
        }
    }
}
