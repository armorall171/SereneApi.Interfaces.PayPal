using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class IncentiveInfoDto
    {
        /// <summary>
        /// An array of incentive details.
        /// </summary>
        [JsonPropertyName("incentive_details")]
        public List<IncentiveDetailDto> IncentiveDetails { get; set; }
    }
}
