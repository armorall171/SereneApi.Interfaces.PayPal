using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class ShippingInfoDto
    {
        /// <summary>
        /// The recipient's name.
        /// </summary>
        [MaxLength(500)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The shipping method that is associated with this order.
        /// </summary>
        [MaxLength(500)]
        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}
