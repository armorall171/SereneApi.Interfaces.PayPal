using SereneApi.Interfaces.PayPal.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.Balance
{
    public class BalanceDto
    {
        /// <summary>
        /// An array of balance detail objects.
        /// </summary>
        [JsonPropertyName("balances")]
        public List<BalanceDetailDto> Balances { get; set; }

        [JsonPropertyName("account_id")]
        [MinLength(13)]
        [MaxLength(13)]
        public string AccountId { get; set; }

        [JsonPropertyName("as_of_time")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime AsOf { get; set; }

        [JsonPropertyName("last_refresh_time")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime LastRefresh { get; set; }


    }
}
