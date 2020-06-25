using SereneApi.Interfaces.PayPal.API.DTOs.Transactions;
using SereneApi.Interfaces.PayPal.API.Queries;
using System;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API.Definitions
{
    public interface ITransactionsApi
    {
        Task<IApiResponse<TransactionDto>> GetAsync();

        Task<IApiResponse<TransactionDto>> GetAsync(Action<TransactionQuery> search);
    }
}
