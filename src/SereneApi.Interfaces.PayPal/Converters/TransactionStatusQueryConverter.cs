using SereneApi.Abstractions.Queries;
using SereneApi.Interfaces.PayPal.API.Enums;

namespace SereneApi.Interfaces.PayPal.Converters
{
    internal class TransactionStatusQueryConverter: QueryConverter<TransactionStatus>
    {
        public override string Convert(TransactionStatus value)
        {
            return value switch
            {
                TransactionStatus.Denied => "D",
                TransactionStatus.PartialRefund => "F",
                TransactionStatus.Pending => "P",
                TransactionStatus.Successful => "S",
                TransactionStatus.Refunded => "V",
                _ => string.Empty
            };
        }
    }
}
