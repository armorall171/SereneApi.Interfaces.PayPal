using SereneApi.Interfaces.PayPal.API.DTOs;

namespace SereneApi.Interfaces.PayPal.API.Definitions
{
    public interface IAuthenticationApi
    {
        IApiResponse<TokenDto> GetToken();
    }
}
