using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class CheckoutOptionDto
    {
        /// <summary>
        /// The checkout option name, such as color or texture.
        /// </summary>
        [MaxLength(200)]
        [JsonPropertyName("checkout_option_name")]
        public string Name { get; set; }

        /// <summary>
        /// The checkout option value. For example, the checkout option color might be blue or red while the checkout option texture might be smooth or rippled.
        /// </summary>
        [MaxLength(200)]
        [JsonPropertyName("checkout_option_value")]
        public string Value { get; set; }
    }
}
