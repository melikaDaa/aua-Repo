using AUA.ProjectName.Models.EntitiesDto.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Utility.Repositories
{
    public interface IAppUserRepository
    {
        Task<List<AppUserDto>> GetUsers();
    }
}
