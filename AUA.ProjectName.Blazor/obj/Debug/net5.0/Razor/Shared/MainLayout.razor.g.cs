#pragma checksum "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f3ad917989b3806f434783d35773ee2770d785a"
// <auto-generated/>
#pragma warning disable 1591
namespace AUA.ProjectName.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Areas.Accounting.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Models.EntitiesDto.Accounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.DomainEntities.Entities.Accounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Pages.Accounting.Role;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Pages.Accounting.UsersAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Models.ListModes.Accounting.UserAccessModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Pages.Accounting.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Utility.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Models.GeneralModels.LoginModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.AuthProviders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Blazor.Utility.ApiAuthorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using AUA.ProjectName.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-s74z968jqc");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-s74z968jqc");
            __builder.OpenComponent<AUA.ProjectName.Blazor.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-s74z968jqc");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-s74z968jqc><a href=\"/Login/Index\" b-s74z968jqc>Login</a>\r\n\r\n            <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-s74z968jqc>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-s74z968jqc");
            __builder.AddContent(15, 
#nullable restore
#line 16 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
