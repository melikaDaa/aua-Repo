using System.Collections.Generic;
using System.Threading.Tasks;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.ListModes.Accounting.UserAccessModels;
using AUA.ProjectName.Services.ListService.Accounting.Contracts;
using AUA.ProjectName.WebApi.Controllers;
using AUA.ProjectName.WebApi.Utility.ApiAuthorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AUA.ProjectName.Blazor.Controllers
{

    public class UserAccessController : BaseApiController
    {
        private readonly IUserAccessListService _userAccessListService;

        public UserAccessController(IUserAccessListService userAccessListService)
        {
                       _userAccessListService = userAccessListService;
        }

        [HttpPost]
        public async Task<ResultModel<ListResultVm<UserAccessListDto>>> ListAsync(UserAccessSearchVm userAccessSearchVm)
        {
            ValidationSearchVm(userAccessSearchVm);

            if (HasError)
                return CreateInvalidResult<ListResultVm<UserAccessListDto>>();

            var result = await _userAccessListService
                                        .ListAsync(userAccessSearchVm);


            return CreateSuccessResult(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<UserAccessListDto>>> ListAsync()
        {
            var result = await _userAccessListService.GetAllDto()
                                           .AsNoTracking()
                                           .ToListAsync();

            return Ok(result);
        }

    }
}