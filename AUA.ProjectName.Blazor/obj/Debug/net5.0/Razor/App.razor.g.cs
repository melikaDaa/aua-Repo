#pragma checksum "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b63402820c3631eea499e60b786c47a4c588b4cd"
// <auto-generated/>
#pragma warning disable 1591
namespace AUA.ProjectName.Blazor
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "PreferExactMatches", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(8);
                __builder2.AddAttribute(9, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "D:\AUA_V1.0_WebApiDotNet5\AUA.ProjectName\AUA.ProjectName.Blazor\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "<p>Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
