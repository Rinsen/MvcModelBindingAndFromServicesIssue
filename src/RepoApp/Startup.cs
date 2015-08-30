using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using Microsoft.AspNet.Mvc;

namespace RepoApp
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<MyService, MyService>();

            // Add MVC services to the services container.
            services.AddMvc();

            //services.AddMvc().Configure<MvcOptions>(options =>
            //{
            //    options.Filters.Add(new AppExceptionFilter());
            //});
        }

        public void Configure(IApplicationBuilder app)
        {

            // Add MVC to the request pipeline.
            app.UseMvcWithDefaultRoute();
        }
    }
}
