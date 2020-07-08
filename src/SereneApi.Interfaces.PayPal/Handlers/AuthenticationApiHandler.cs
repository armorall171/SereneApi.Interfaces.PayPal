using SereneApi.Abstractions.Options;
using SereneApi.Abstractions.Request;
using SereneApi.Abstractions.Request.Content;
using SereneApi.Abstractions.Response;
using SereneApi.Interfaces.PayPal.API;
using SereneApi.Interfaces.PayPal.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.Handlers
{
    internal class AuthenticationApiHandler: ApiHandler, IAuthenticationApi
    {
        public AuthenticationApiHandler(IApiOptions<IAuthenticationApi> options) : base(options)
        {
        }

        public IApiResponse<TokenDto> GetToken()
        {
            IApiRequestContent content = new FormUrlEncodedContent(new Dictionary<string, string> { { "grant_type", "client_credentials" } });

            return PerformRequest<TokenDto>(Method.POST, r => r
                .WithEndPoint("token")
                .WithInBodyContent(content));
        }

        public Task<IApiResponse<TokenDto>> GetTokenAsync()
        {
            IApiRequestContent content = new FormUrlEncodedContent(new Dictionary<string, string> { { "grant_type", "client_credentials" } });

            return PerformRequestAsync<TokenDto>(Method.POST, r => r
                .WithEndPoint("token")
                .WithInBodyContent(content));
        }
    }
}
