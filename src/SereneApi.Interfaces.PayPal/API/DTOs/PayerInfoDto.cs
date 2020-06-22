using SereneApi.Interfaces.PayPal.API.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class PayerInfoDto
    {
        /// <summary>
        /// The PayPal customer account ID.
        /// </summary>
        [MaxLength(13)]
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The email address of the payer.
        /// </summary>
        [MinLength(3)]
        [MaxLength(254)]
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary phone number of the payer.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public PhoneDto PhoneNumber { get; set; }

        /// <summary>
        /// The address status of the payer.
        /// </summary>
        [JsonPropertyName("address_status")]
        public VerificationStatus AddressStatus { get; set; }

        /// <summary>
        /// The status of the payer.
        /// </summary>
        [JsonPropertyName("payer_status")]
        public VerificationStatus PayerStatus { get; set; }

        /// <summary>
        /// The payer name.
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// The <see href="https://developer.paypal.com/docs/integration/direct/rest/country-codes/">two-character ISO 3166-1 code</see> that identifies the country or region of the payer.
        /// </summary>
        [MinLength(2)]
        [MaxLength(2)]
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The payer address.
        /// </summary>
        public string Address { get; set; }
    }
}
