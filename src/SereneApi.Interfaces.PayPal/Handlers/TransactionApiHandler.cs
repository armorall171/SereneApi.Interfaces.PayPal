
using SereneApi.Extensions.DependencyInjection.Interfaces;
using SereneApi.Interfaces.PayPal.API.Definitions;
using SereneApi.Interfaces.PayPal.API.DTOs.Transactions;
using SereneApi.Interfaces.PayPal.API.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.Handlers
{
    public class TransactionApiHandler: ApiHandler, ITransactionsApi
    {
        public TransactionApiHandler(IApiHandlerOptions<TransactionApiHandler> options) : base(options)
        {
        }

        public Task<IApiResponse<List<TransactionDto>>> GetAsync()
        {
            return PerformRequestAsync<List<TransactionDto>>(Method.Get);
        }

        public Task<IApiResponse<List<TransactionDto>>> GetAsync(Action<TransactionQuery> search)
        {
            TransactionQuery query = new TransactionQuery();

            search.Invoke(query);

            return PerformRequestAsync<List<TransactionDto>>(Method.Get,
                r => r.WithQuery(query));
        }
    }
}
