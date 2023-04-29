using AUA.ProjectName.Blazor.AuthProviders;
using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.Blazor.Utility.Repositories;
using AUA.ProjectName.Services.GeneralService.Login.Contracts;
using AUA.ProjectName.Services.GeneralService.Login.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using AUA.ProjectName.Blazor.Utility;

namespace AUA.ProjectName.Blazor.RegistrationServices

{
    public static class GeneralService
    {
        public static void RegistrationGeneralServices(this IServiceCollection services)
        {

            services.RegistrationAccessServices();
            services.RegistrationBlazorServices();

        }

        private static void RegistrationAccessServices(this IServiceCollection services)
        {
           
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IRefreshTokenService, RefreshTokenService>();
            services.AddScoped<IAccessTokenService, AccessTokenService>();
            services.AddScoped<ILogoutService, LogoutService>();

        }


        public static void RegistrationBlazorServices(this IServiceCollection services)
        {
            {
                services.AddHttpClient();
                services.AddScoped<IHttpService, HttpService>();
                services.AddScoped<IRoleRepository, RoleRepository>();
                services.AddScoped<IAppUserRepository, AppUserRepository>();
                services.AddScoped<IUserAccessRepository, UserAccessRepository>();
                services.AddScoped<IAuthenticationServices, Utility.AuthenticationService>();
                services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
                services.AddScoped<ILocalStorageServices, LocalStorageService>();
                services.AddBlazoredLocalStorage();
                services.AddAuthorizationCore();
                services.AddOptions();
            }
        }
    }
    }
