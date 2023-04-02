using AUA.ProjectName.Common.Consts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CreateHostBuilder(args).Build().Run();

        }
        private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
                                                     .ConfigureAppConfiguration((hostingContext, config) =>
                                                     {
                                                         config.SetBasePath(Directory.GetCurrentDirectory());
                                                         config.AddJsonFile(AppConsts.AppSettingsFileName, optional: true, reloadOnChange: true);
                                                         config.AddJsonFile(AppConsts.AppSettingsFilePath, optional: false, reloadOnChange: true);
                                                         config.AddEnvironmentVariables();
                                                     })
                                                     .ConfigureWebHostDefaults(webBuilder =>
                                                     {
                                                         webBuilder.UseStartup(AppConsts.AppDlName);
                                                     });

    }
}
