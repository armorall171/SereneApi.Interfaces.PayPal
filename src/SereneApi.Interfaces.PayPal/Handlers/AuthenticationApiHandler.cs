using SereneApi.Abstractions.Options;
using SereneApi.Abstractions.Request;
using SereneApi.Abstractions.Request.Content;
using SereneApi.Abstractions.Response;
using SereneApi.Interfaces.PayPal.API;
using SereneApi.Interfaces.PayPal.API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using SereneApi.Interfaces.PayPal.API.Authentication;

namespace SereneApi.Interfaces.PayPal.Handlers
{
    internal class AuthenticationApiHandler: BaseApiHandler, IAuthenticationApi
    {
        public AuthenticationApiHandler(IApiOptions<IAuthenticationApi> options) : base(options)
        {
        }

        public Task<IApiResponse<TokenDto>> AuthenticateAsync()
        {
            IApiRequestContent content = new FormUrlEncodedContent(new Dictionary<string, string> { { "grant_type", "client_credentials" } });

            return PerformRequestAsync<TokenDto>(Method.POST, r => r
                .WithEndpoint("token")
                .WithInBodyContent(content));
        }
    }
}
