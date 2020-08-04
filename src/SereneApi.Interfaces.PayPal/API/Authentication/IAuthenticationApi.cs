using System;
using System.Threading.Tasks;
using SereneApi.Abstractions.Response;

namespace SereneApi.Interfaces.PayPal.API.Authentication
{
    internal interface IAuthenticationApi: IDisposable
    {
        Task<IApiResponse<TokenDto>> AuthenticateAsync();
    }
}
