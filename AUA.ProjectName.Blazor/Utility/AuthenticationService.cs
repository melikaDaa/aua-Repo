using System;
using System.Net;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using AUA.ProjectName.Blazor.AuthProviders;
using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.DataModels.LoginDataModels;
using AUA.ProjectName.Models.GeneralModels.AccessTokenModels;
using Newtonsoft.Json;

namespace AUA.ProjectName.Blazor.Utility
{
    public class AuthenticationService : IAuthenticationServices
    {

        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly ILocalStorageServices _localStorage;


        public AuthenticationService(HttpClient client, AuthenticationStateProvider authStateProvider, ILocalStorageServices localStorage)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _authStateProvider = authStateProvider;
            _localStorage = localStorage;
        }





        public async Task<ActiveAccessToken> Login(LoginVm userForAuthentication)
        {

            string serializedUser = JsonConvert.SerializeObject(userForAuthentication);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44388/api/UserAccount/Login");
            requestMessage.Content = new StringContent(serializedUser);
            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _client.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<ActiveAccessToken>(responseBody);

            await _localStorage.SetItem("authToken", returnedUser.AccessToken);


            return returnedUser;



        }


        public async Task Logout()
        {
            await _localStorage.RemoveItem("authToken");
            ((AuthStateProvider)_authStateProvider).NotifyUserLogout();
            _client.DefaultRequestHeaders.Authorization = null;
        }

    }
}


