using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class ItemDetailTaxAmountDto
    {
        /// <summary>
        /// The tax levied by a government on the purchase of goods or services.
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public MoneyDto Amount { get; set; }
    }
}
