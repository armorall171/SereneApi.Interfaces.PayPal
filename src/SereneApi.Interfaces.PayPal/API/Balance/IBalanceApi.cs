using SereneApi.Abstractions.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SereneApi.Interfaces.PayPal.API.Balance
{
    public interface IBalanceApi
    {
        Task<IApiResponse<List<BalanceDto>>> GetAsync();
    }
}
