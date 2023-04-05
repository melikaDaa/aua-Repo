using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Tools.Config.JsonSetting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AUA.ProjectName.Blazor.AppConfiguration
{
    public static class AppConfigExtension
    {
        public static void Configuration(this IApplicationBuilder app)
        {
            app.UseCors();

            app.DefaultConfiguration();


            app.MiddlewareConfiguration();

            app.BlazorConfiguration();

        }

        private static void DefaultConfiguration(this IApplicationBuilder app)
        {
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

        }

        private static void UseCors(this IApplicationBuilder app)
        {
            app.UseCors(options => options.AllowAnyOrigin()
                                          .AllowAnyHeader()
                                          .AllowAnyMethod());
        }


        private static void MiddlewareConfiguration(this IApplicationBuilder app)
        {
           // app.UseSession();

             //app.UseCookiePolicy();

            //app.UseAuthentication();

             //app.UseHttpsRedirection();

//              app.UseStaticFiles();

  //            app.UseCookiePolicy();

        }

        public static void BlazorConfiguration(this IApplicationBuilder app)
        {
          
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

    }
}
