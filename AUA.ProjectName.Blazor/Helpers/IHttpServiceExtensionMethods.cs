using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Helpers
{
    public static class IHttpServiceExtensionMethods
    {
        public static async Task<T> GetHelper<T>(this IHttpService httpService, string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.IsSuccess)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
    }
}
