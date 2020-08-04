using Microsoft.Extensions.DependencyInjection;
using SereneApi.Abstractions.Authorization.Authorizers;
using SereneApi.Extensions.DependencyInjection;
using SereneApi.Interfaces.PayPal.API;
using SereneApi.Interfaces.PayPal.API.Authentication;
using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.API.Transaction;
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

            serviceCollection.RegisterApi<IAuthenticationApi, AuthenticationApiHandler>(o =>
            {
                o.UseSource(payPalSource,
                    PayPalApiSettings.AuthenticationResource,
                    PayPalApiSettings.AuthenticationResourcePath);
                o.AddBasicAuthentication(credentials.Username, credentials.Password);
            });

            serviceCollection.RegisterApi<ITransactionApi, TransactionApiHandler>(o =>
            {
                o.UseSource(
                    payPalSource,
                    PayPalApiSettings.TransactionResource,
                    PayPalApiSettings.TransactionResourcePath);
            })
            .AddDIAuthenticator<IAuthenticationApi, TokenDto>(
                api => api.AuthenticateAsync(),
                s => new TokenAuthResult(s.AccessToken, s.ExpiresIn)
            );
        }
    }
}
