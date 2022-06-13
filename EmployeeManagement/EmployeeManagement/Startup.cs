using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            FileServerOptions option = new FileServerOptions();
            option.DefaultFilesOptions.DefaultFileNames.Clear();
            option.DefaultFilesOptions.DefaultFileNames.Add("/welcome/home.html");

            app.UseRouting();
            app.UseFileServer(option);
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("\nHello world from the third middleware");
            //    await next();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello world from the first middleware");
                    await context.Response.WriteAsync("\nHello world from the second middleware");
                });
            });


        }
    }
}
