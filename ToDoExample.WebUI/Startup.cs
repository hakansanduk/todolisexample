using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using ToDoExample.Business.Abstract;
using ToDoExample.Business.Concrete;
using ToDoExample.DataAccess.Abstract;
using ToDoExample.DataAccess.Concrete.EF;
using ToDoExample.Entities;

namespace ToDoExample.WebUI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<IToDoListDal, EFToDoListDal>();
            services.AddScoped<IToDoItemDal, EFToDoItemDal>();

            services.AddScoped<IToDoListService, ToDoListManager>();
            services.AddScoped<IToDoItemService, ToDoItemManager>();

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //wwwroot klasörünün erişime açılması için
            app.UseStaticFiles();

            //node_modules klasörünün erişime açılması için
            var path = Path.Combine(Directory.GetCurrentDirectory(), "node_modules");
            var options = new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(path),
                RequestPath = "/modules"
            };
            app.UseStaticFiles(options);

            //Defaul route tanımlaması
            app.UseMvcWithDefaultRoute();
        }
    }
}
