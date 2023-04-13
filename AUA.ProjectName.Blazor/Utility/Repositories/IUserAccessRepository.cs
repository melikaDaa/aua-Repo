using AUA.ProjectName.Models.ListModes.Accounting.UserAccessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Utility.Repositories
{
   public interface IUserAccessRepository
    {
        Task<List<UserAccessListDto>> GetUsersAccess();
    }
}
