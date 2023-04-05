using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Helpers
{
    public static class IJsRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "example", "toplearn blazor course");
            return await js.InvokeAsync<bool>("confirm", message);
        }
  
    }
}
