using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs.Transactions
{
    public class TransactionDto
    {
        [JsonPropertyName("transaction_details")]
        public List<TransactionDetailDto> TransactionDetails { get; set; }

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("end_date")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("last_refreshed_datetime")]
        public DateTime LastRefreshed { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("links")]
        public List<LinkDescriptionDto> Links { get; set; }
    }
}
