
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Utility

{
    public  interface IAuthenticationService
    {
        Task<LoginVm> RegisterUser(LoginVm userForRegistration);
        Task<LoginResultVm> Login(LoginVm userForAuthentication);
        Task Logout();
    }
}
