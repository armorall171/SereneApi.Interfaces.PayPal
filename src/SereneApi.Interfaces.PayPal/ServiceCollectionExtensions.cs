using Microsoft.Extensions.DependencyInjection;
using SereneApi.Abstractions.Authentication;
using SereneApi.Extensions.DependencyInjection;
using SereneApi.Interfaces.PayPal.API;
using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.Handlers;

namespace SereneApi.Interfaces.PayPal
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPayPalApi(this IServiceCollection serviceCollection, PayPalCredentials credentials, bool useSandbox = false)
        {
            string payPalSource;

            if(useSandbox)
            {
                payPalSource = PayPalApiSettings.PayPalSandboxSource;
            }
            else
            {
                payPalSource = PayPalApiSettings.PayPalSource;
            }

            serviceCollection.RegisterApiHandler<IAuthenticationApi, AuthenticationApiHandler>(o =>
            {
                o.UseSource(payPalSource,
                    PayPalApiSettings.AuthenticationResource,
                    PayPalApiSettings.AuthenticationResourcePath);
                o.AddBasicAuthentication(credentials.Username, credentials.Password);
            });

            serviceCollection.RegisterApiHandler<ITransactionsApi, TransactionApiHandler>(o =>
            {
                o.UseSource(
                    payPalSource,
                    PayPalApiSettings.TransactionResource,
                    PayPalApiSettings.TransactionResourcePath);
            })
            .AddAuthenticator<IAuthenticationApi, TokenDto>(
                api => api.GetTokenAsync(),
                s => new TokenInfo(s.AccessToken, s.ExpiresIn)
            );
        }
    }
}
