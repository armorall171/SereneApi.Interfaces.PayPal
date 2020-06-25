using Microsoft.Extensions.DependencyInjection;
using SereneApi.Extensions.DependencyInjection;
using SereneApi.Interfaces.PayPal.API.Definitions;
using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.Handlers;
using SereneApi.Interfaces.PayPal.Types;
using SereneApi.Types;

namespace SereneApi.Interfaces.PayPal.Extensions
{
    public static class IServiceCollectionExtensions
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
