using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AUA.ProjectName.Blazor.Helpers
{
    public interface IHttpService
    {
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<T>> Delete<T>(string url);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T data);


    }
}
