using System.Threading.Tasks;
using SereneApi.Abstractions.Response;

namespace SereneApi.Interfaces.PayPal.API.Payment.Authorizations
{
    public interface IAuthorizationApi
    {
        Task<IApiResponse<AuthorizationDto>> GetAsync(string authorizationId);
    }
}
