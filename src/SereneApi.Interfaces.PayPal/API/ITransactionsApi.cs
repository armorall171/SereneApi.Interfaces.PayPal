using SereneApi.Abstractions.Response;
using SereneApi.Interfaces.PayPal.API.DTOs.Transactions;
using SereneApi.Interfaces.PayPal.API.Queries;
using System;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API
{
    public interface ITransactionsApi: IDisposable
    {
        Task<IApiResponse<TransactionDto>> GetAsync();

        Task<IApiResponse<TransactionDto>> GetAsync(Action<TransactionQuery> search);
    }
}
