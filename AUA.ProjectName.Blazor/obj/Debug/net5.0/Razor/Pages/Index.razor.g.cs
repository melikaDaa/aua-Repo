#pragma checksum "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b35927b4e9dba6d182a40f9a744ddfb3c0906081"
// <auto-generated/>
#pragma warning disable 1591
namespace AUA.ProjectName.Blazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""text-center p-5""><div class=""alert  alert-success  fade show"">
        Welcome to  Asp.Net Unique Architecture
    </div>
    <p style=""text-align: justify"" class=""p-3"">
        Using the AUA  ( <strong><span style=""color: #dc143c""> A</span>sp.Net <span style=""color: #dc143c"">U</span>nique <span style=""color: #dc143c"">A</span>rchitecture</strong> ) Framework, you can easily have better, faster, and more orderly and focused coding.
        This framework is based on new and up-to-date concepts, structures and architectures, including:
        <strong>Clean Architecture</strong>,
        <strong>Clean Code</strong>,
        <srtong>Domain-driven design (DDD)</srtong>,
        <srtong>Lmax Architecture</srtong>,
        <strong>SOLID Principle</strong>,
        <strong>Code Refactoring</strong>,
        <strong>GRASP (object-oriented design principle)</strong>.

    </p>
    <img src=""~/img/687474703a2f2f6865696c746f6e2e636f6d2f4155415f66696c65732f696d6167653030322e706e67.png"">
    <p class=""p-5"">Learn about <a href=""https://auaframework.com/Document/Introduction"">building Web apps with AUA Framework</a>.</p>


    <hr>

    <div class=""alert alert-primary"" role=""alert""><p>
            The AUA team suggests using the WebApi version and writing the UI from a JavaScript framework such as Angular ,Vue Js, ....
        </p></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
