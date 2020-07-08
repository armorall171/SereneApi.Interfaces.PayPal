using SereneApi.Abstractions.Options;
using SereneApi.Abstractions.Request;
using SereneApi.Abstractions.Response;
using SereneApi.Interfaces.PayPal.API;
using SereneApi.Interfaces.PayPal.API.DTOs.Transactions;
using SereneApi.Interfaces.PayPal.API.Queries;
using System;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.Handlers
{
    internal class TransactionApiHandler: ApiHandler, ITransactionsApi
    {
        public TransactionApiHandler(IApiOptions<ITransactionsApi> options) : base(options)
        {
        }

        public Task<IApiResponse<TransactionDto>> GetAsync()
        {
            return PerformRequestAsync<TransactionDto>(Method.GET);
        }

        public Task<IApiResponse<TransactionDto>> GetAsync(Action<TransactionQuery> search)
        {
            TransactionQuery query = new TransactionQuery();

            search.Invoke(query);

            //return PerformRequestAsync<TransactionDto>(Method.GET);

            return PerformRequestAsync<TransactionDto>(Method.GET,
                r => r.WithQuery(query));
        }
    }
}
