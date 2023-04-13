using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.Models.ListModes.Accounting.UserAccessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Utility.Repositories
{
    public class UserAccessRepository : IUserAccessRepository
    {
        private readonly IHttpService httpService;

        private string url = "https://localhost:44388/api/UserAccess/";

        public UserAccessRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<List<UserAccessListDto>> GetUsersAccess()
        {
            var response = await httpService.Get<List<UserAccessListDto>>(url);

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
