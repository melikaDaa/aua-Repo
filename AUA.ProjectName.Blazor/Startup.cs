
using AUA.ProjectName.Blazor.AppConfiguration;
using AUA.ProjectName.Common.Consts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor
{
    public class StartupDevelopment
    {
        public IConfiguration Configuration { get; }

        public StartupDevelopment(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configuration();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseExceptionHandler(AppConsts.ExceptionHandler);
            app.UseDeveloperExceptionPage();

            app.UseHsts();

            app.Configuration();

        }
    }
}
