using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.Transaction
{
    public class TransactionDto
    {
        /// <summary>
        /// An array of transaction detail objects.
        /// </summary>
        [JsonPropertyName("transaction_details")]
        public List<TransactionDetailDto> TransactionDetails { get; set; }

        /// <summary>
        /// The merchant account number.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The start date and time, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>.
        /// </summary>
        [JsonPropertyName("start_date")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date and time or the last date when the data can be served, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>.
        /// </summary>
        [JsonPropertyName("end_date")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The date and time when the data was last refreshed, in <see href="https://tools.ietf.org/html/rfc3339#section-5.6">Internet date and time format</see>.
        /// </summary>
        [JsonPropertyName("last_refreshed_datetime")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime LastRefreshed { get; set; }

        /// <summary>
        /// A zero-relative index of transactions.
        /// </summary>
        [MinLength(0)]
        [MaxLength(2147483647)]
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        /// The total number of transactions as an integer beginning with the specified page in the full result and not just in this response.
        /// </summary>
        [MinLength(0)]
        [MaxLength(2147483647)]
        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }

        /// <summary>
        /// The total number of pages, as an integer, when the total_items is divided into pages of the specified page_size.
        /// </summary>
        [MinLength(0)]
        [MaxLength(2147483647)]
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// An array of request-related <see href="https://developer.paypal.com/docs/api/reference/api-responses/#hateoas-links">HATEOAS links</see>.
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionDto> Links { get; set; }
    }
}
