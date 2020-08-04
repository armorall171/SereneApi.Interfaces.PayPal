using SereneApi.Abstractions.Options;
using SereneApi.Abstractions.Request;
using SereneApi.Abstractions.Response;
using SereneApi.Interfaces.PayPal.API.Transaction;
using System;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.Handlers
{
    internal class TransactionApiHandler: BaseApiHandler, ITransactionApi
    {
        public TransactionApiHandler(IApiOptions<ITransactionApi> options) : base(options)
        {
        }

        public Task<IApiResponse<TransactionDto>> GetAsync(TransactionQuery search)
        {
            return PerformRequestAsync<TransactionDto>(Method.GET,
                r => r.WithQuery(search));
        }

        public Task<IApiResponse<TransactionDto>> GetAsync(Action<TransactionQuery> search)
        {
            TransactionQuery query = new TransactionQuery();

            search.Invoke(query);

            return GetAsync(query);
        }
    }
}
