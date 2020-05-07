using System;
using System.Threading.Tasks;
using Refit;
using Adda52_REFIT.Model;

namespace Adda52_REFIT.Interface
{
    [Headers("User-Agent: :request:")]
    interface IGitHubApi
    {
        [Get("/search/users?q=location:lagos")]
        Task<ApiResponse> GetUser();
    }
}
