using SereneApi.Abstractions.Response;
using System;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API.Transaction
{
    public interface ITransactionApi
    {
        Task<IApiResponse<TransactionDto>> GetAsync(TransactionQuery search);
        Task<IApiResponse<TransactionDto>> GetAsync(Action<TransactionQuery> search);
    }
}
