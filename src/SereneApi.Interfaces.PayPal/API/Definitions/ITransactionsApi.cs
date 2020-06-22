using SereneApi.Interfaces.PayPal.API.DTOs.Transactions;
using SereneApi.Interfaces.PayPal.API.Queries;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API.Definitions
{
    public interface ITransactionsApi
    {
        Task<IApiResponse<List<TransactionDto>>> GetAsync();

        Task<IApiResponse<List<TransactionDto>>> GetAsync(Action<TransactionQuery> search);
    }
}
