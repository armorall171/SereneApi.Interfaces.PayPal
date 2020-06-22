using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class AddressDto
    {
        /// <summary>
        /// The first line of the address. For example, number or street.
        /// </summary>
        [Required]
        [JsonPropertyName("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of the address. For example, suite or apartment number.
        /// </summary>
        [JsonPropertyName("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// The city name.
        /// </summary>
        [Required]
        [JsonPropertyName("cite")]
        public string City { get; set; }

        /// <summary>
        /// The <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/">code</see> for a US state or the equivalent for other countries.
        /// Required for transactions if the address is in one of these countries:
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#argentina">Argentina</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#brazil">Brazil</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#canada">Canada</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#china">China</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#india">India</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#italy">Italy</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#japan">Japan</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#mexico">Mexico</see>,
        /// <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#thailand">Thailand</see>,
        /// or <see href="https://developer.paypal.com/docs/integration/direct/rest/state-codes/#usa">United States</see>.
        /// Maximum length is 40 single-byte characters.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The <see href="The two-character ISO 3166-1 code that identifies the country or region.">two-character ISO 3166-1 code</see> that identifies the country or region.
        /// </summary>
        [Required]
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }
    }
}
