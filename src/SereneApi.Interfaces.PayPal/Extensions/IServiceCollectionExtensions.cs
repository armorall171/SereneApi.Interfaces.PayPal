using Microsoft.Extensions.DependencyInjection;
using SereneApi.Abstraction.Enums;
using SereneApi.Extensions.DependencyInjection;
using SereneApi.Extensions.Mocking;
using SereneApi.Interfaces.PayPal.API.Definitions;
using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.API.DTOs.Transactions;
using SereneApi.Interfaces.PayPal.Handlers;
using SereneApi.Interfaces.PayPal.Types;
using SereneApi.Types;

// DO NOTE CHANGE
// ReSharper disable once CheckNamespace
namespace SereneApi.Interfaces.PayPal
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
            .AddInjectedAuthenticator<IAuthenticationApi, TokenDto>(
                api => api.GetTokenAsync(),
                s => new TokenInfo(s.AccessToken, s.ExpiresIn)
            )
            .WithMockResponses(r =>
            {
                r.AddMockResponse(new TransactionDto())
                    .RespondsToRequestsWith(Method.GET);
            });
        }
    }
}
