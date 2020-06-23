using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class StoreInfoDto
    {
        /// <summary>
        /// The ID of a store for a merchant in the system of record.
        /// </summary>
        [MaxLength(100)]
        [JsonPropertyName("store_id")]
        public string Id { get; set; }

        /// <summary>
        /// The terminal ID for the checkout stand in a merchant store.
        /// </summary>
        [MaxLength(60)]
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }
    }
}
