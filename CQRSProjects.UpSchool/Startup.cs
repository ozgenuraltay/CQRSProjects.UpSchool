using CQRSProjects.UpSchool.CQRS.Handlers.ProductHandlers;
using CQRSProjects.UpSchool.CQRS.Handlers.StudentHandlers;
using CQRSProjects.UpSchool.DAL.Context;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSProjects.UpSchool
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProductContext>();

            services.AddMediatR(typeof(Startup));

            services.AddScoped<GetProductByAcounterQueryHandler>();
            services.AddScoped<GetProductByStoragerQueryHandler>();
            services.AddScoped<GetProductByHumanResourceByIDQueryHandler>();
            services.AddScoped<GetProductByAccounterByIDQueryHandler>();
            services.AddScoped<CreateProductCommandHandler>();
            services.AddScoped<CreateStudentCommandHandler>();
            services.AddScoped<GetAllStudentQueryHandler>();
            services.AddScoped<RemoveStudentCommandHandler>();
            services.AddScoped<GetStudentByIDQueryHandler>();
            services.AddScoped<UpdateStudentCommandHandler>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
