using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class IncentiveDetailDto
    {
        /// <summary>
        /// The type of incentive, such as a special offer or coupon.
        /// </summary>
        [MaxLength(500)]
        [JsonPropertyName("incentive_type")]
        public string Type { get; set; }

        /// <summary>
        /// The code that identifies an incentive, such as a coupon.
        /// </summary>
        [MaxLength(200)]
        [JsonPropertyName("incentive_code")]
        public string Code { get; set; }

        /// <summary>
        /// The incentive amount.
        /// </summary>
        [JsonPropertyName("incentive_amount")]
        public MoneyDto Amount { get; set; }

        /// <summary>
        /// The incentive program code that identifies a merchant loyalty or incentive program.
        /// </summary>
        [MaxLength(100)]
        [JsonPropertyName("incentive_program_code")]
        public string ProgramCode { get; set; }
    }
}
