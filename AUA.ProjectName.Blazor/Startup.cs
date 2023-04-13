
using AUA.ProjectName.Blazor.AppConfiguration;
using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.Blazor.Utility.Repositories;
using AUA.ProjectName.Common.Consts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseExceptionHandler(AppConsts.ExceptionHandler);
            app.UseDeveloperExceptionPage();

            app.UseHsts();

            app.Configuration();

        }
    }
}
