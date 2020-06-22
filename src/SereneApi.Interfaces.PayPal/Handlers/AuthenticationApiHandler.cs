using SereneApi.Extensions.DependencyInjection.Interfaces;
using SereneApi.Interfaces.PayPal.API.Definitions;
using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.Requests;
using SereneApi.Types.Content;
using System.Collections.Generic;

namespace SereneApi.Interfaces.PayPal.Handlers
{
    public class AuthenticationApiHandler: ApiHandler, IAuthenticationApi
    {
        public AuthenticationApiHandler(IApiHandlerOptions<AuthenticationApiHandler> options) : base(options)
        {
        }


        public IApiResponse<TokenDto> GetToken()
        {
            IApiRequestContent content = new FormUrlEncodedContent(new Dictionary<string, string> { { "grant_type", "client_credentials" } });

            return PerformRequest<TokenDto>(Method.Post, r => r
                .WithEndPoint("token")
                .WithInBodyContent(content));
        }
    }
}
