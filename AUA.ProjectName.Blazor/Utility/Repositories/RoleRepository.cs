using AUA.ProjectName.Blazor.Helpers;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Utility.Repositories
{
    public class RoleRepository:IRoleRepository
    {
        private readonly IHttpService httpService;

        private string url = "https://localhost:44388/api/Role/";

        public RoleRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        public async Task<List<RoleDto>> GetGenres()
        {
            var response = await httpService.Get<List<RoleDto>>(url);

            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
