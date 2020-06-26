using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class PhoneDto
    {
        /// <summary>
        /// The country calling code (CC), in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>.
        /// The combined length of the CC and the national number must not be greater than 15 digits.
        /// The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [MinLength(1)]
        [MaxLength(3)]
        [JsonPropertyName("county_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// The national number, in its canonical international <see href="https://www.itu.int/rec/T-REC-E.164/en">E.164 numbering plan format</see>.
        /// The combined length of the country calling code (CC) and the national number must not be greater than 15 digits.
        /// The national number consists of a national destination code (NDC) and subscriber number (SN).
        /// </summary>
        [MinLength(1)]
        [MaxLength(14)]
        [JsonPropertyName("national_name")]
        public int NationalNumber { get; set; }

        /// <summary>
        /// The extension number.
        /// </summary>
        [MinLength(1)]
        [MaxLength(15)]
        [JsonPropertyName("extension_number")]
        public int ExtensionNumber { get; set; }
    }
}
