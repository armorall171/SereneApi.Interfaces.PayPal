using SereneApi.Interfaces.PayPal.API.DTOs;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API.Definitions
{
    internal interface IAuthenticationApi
    {
        IApiResponse<TokenDto> GetToken();

        Task<IApiResponse<TokenDto>> GetTokenAsync();
    }
}
