using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class MoneyDto
    {
        /// <summary>
        /// The <see href="https://developer.paypal.com/docs/integration/direct/rest/currency-codes/">three-character ISO-4217 currency code</see> that identifies the currency.
        /// </summary>
        [Required]
        [MinLength(3)]
        [MaxLength(3)]
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        [MaxLength(32)]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
