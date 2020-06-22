using Microsoft.Extensions.DependencyInjection;
using SereneApi.Interfaces.PayPal.API.Definitions;
using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.Handlers;
using SereneApi.Interfaces.PayPal.Types;

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

            TokenDto token;

            using(ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider())
            {
                IAuthenticationApi authApi = serviceProvider.GetRequiredService<IAuthenticationApi>();

                IApiResponse<TokenDto> tokenResponse = authApi.GetToken();

                if(!tokenResponse.WasSuccessful)
                {
                }

                token = tokenResponse.Result;
            }

            serviceCollection.RegisterApiHandler<ITransactionsApi, TransactionApiHandler>(o =>
            {
                o.UseSource(
                    payPalSource,
                    PayPalApiSettings.TransactionResource,
                    PayPalApiSettings.TransactionResourcePath);
                o.AddBearerAuthentication(token.AccessToken);
            });
        }
    }
}
