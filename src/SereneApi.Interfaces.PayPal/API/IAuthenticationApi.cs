using SereneApi.Abstractions.Response;
using SereneApi.Interfaces.PayPal.API.DTOs;
using System;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API
{
    internal interface IAuthenticationApi: IDisposable
    {
        IApiResponse<TokenDto> GetToken();

        Task<IApiResponse<TokenDto>> GetTokenAsync();
    }
}
