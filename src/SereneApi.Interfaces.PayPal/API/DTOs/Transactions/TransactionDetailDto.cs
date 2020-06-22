using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs.Transactions
{
    public class TransactionDetailDto
    {
        /// <summary>
        /// The transaction information.
        /// </summary>
        [JsonPropertyName("transaction_info")]
        public TransactionInfoDto TransactionInfo { get; set; }

        /// <summary>
        /// The payer information.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInfoDto PayerInfo { get; set; }

        /// <summary>
        /// The shipping information.
        /// </summary>
        [JsonPropertyName("shipping_info")]
        public ShippingInfoDto ShippingInfo { get; set; }
    }
}
