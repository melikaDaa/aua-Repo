using AUA.ProjectName.Blazor.AuthProviders;
using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.Services.GeneralService.Login.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace AUA.ProjectName.Blazor.RegistrationServices

{
    public static class GeneralService
    {
        public static void RegistrationGeneralServices(this IServiceCollection services)
        {

            services.RegistrationAccessServices();

        }

        private static void RegistrationAccessServices(this IServiceCollection services)
        {
           
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            services.AddScoped<IAccessTokenService, AccessTokenService>();
            services.AddScoped<ILogoutService, LogoutService>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();

            services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddBlazoredLocalStorage();
              services.AddAuthorizationCore();
        }

    

    }
}
