using Blazored.LocalStorage;

using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using AUA.ProjectName.Blazor.AuthProviders;

namespace AUA.ProjectName.Blazor.Utility
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageService _localStorage;
        public AuthenticationService(HttpClient client, AuthenticationStateProvider authStateProvider, ILocalStorageService localStorage)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }
        public async Task<LoginVm> RegisterUser(LoginVm userForRegistration)
        {
            var content = JsonSerializer.Serialize(userForRegistration);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var registrationResult = await _client.PostAsync("api/accounts/registration", bodyContent);
            var registrationContent = await registrationResult.Content.ReadAsStringAsync();
            if (!registrationResult.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<LoginVm>(registrationContent, _options);
                return result;
            }
            return new LoginVm { };
        }

        public async Task<LoginResultVm> Login(LoginVm userForAuthentication)
        {
            var content = JsonSerializer.Serialize(userForAuthentication);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var authResult = await _client.PostAsync("api/UserAccount/LoginAsync", bodyContent);
            var authContent = await authResult.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<LoginResultVm>(authContent, _options);

            if (!authResult.IsSuccessStatusCode)
                return result;

            await _localStorage.SetItemAsync("authToken", result.AccessToken);
            ((AuthStateProvider)_authStateProvider).NotifyUserAuthentication(userForAuthentication.UserName);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.AccessToken);

            return result;
                }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }
    }
}
