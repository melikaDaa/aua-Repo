using AUA.ProjectName.DomainEntities.Entities.Accounting;
using AUA.ProjectName.Models.GeneralModels.LoginModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUA.ProjectName.Models.DataModels.LoginDataModels;

namespace AUA.ProjectName.Blazor.Utility

{
    public interface IAuthenticationServices
    {
        Task<ActiveAccessToken> Login(LoginVm LogVm);

        Task Logout();
    }
}