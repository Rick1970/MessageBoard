using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MessageBoard.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BasicAuthentication.Models;
using Hangfire;
using System;
using System.Diagnostics;
using MessageBoard.Controllers;

namespace MessageBoard
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
       
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFramework()
                .AddDbContext<MessageBoardDbContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddIdentity<User, IdentityRole>()
                    .AddEntityFrameworkStores<MessageBoardDbContext>();
            services.AddHangfire(x => x.UseSqlServerStorage(Configuration["ConnectionStrings:HangfireDb"]));
            
        }

        public void Configure(IApplicationBuilder app)
        {
            
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseFileServer();
            app.UseIdentity();
            app.UseHangfireDashboard();
            app.UseHangfireServer();
           
            RecurringJob.AddOrUpdate(
                () => Debug.WriteLine("Minutely Job"), Cron.Minutely);

            

           


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=index}/{id?}");
            });


        }

       
    }
}