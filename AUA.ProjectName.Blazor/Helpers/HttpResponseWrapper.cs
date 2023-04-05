using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Helpers
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool isSuccess, HttpResponseMessage httpResponseMessage)
        {
            IsSuccess = isSuccess;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public bool IsSuccess { get; set; }

        public T Response { get; set; }

        public HttpResponseMessage HttpResponseMessage { get; set; }
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
    }
