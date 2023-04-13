using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Utility.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IHttpService httpService;
        private string url = "https://localhost:44388/api/AppUSer/";
        public AppUserRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

    
        public async Task<List<AppUserDto>> GetUsers()
        {
            var response = await httpService.Get<List<AppUserDto>>(url);

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
