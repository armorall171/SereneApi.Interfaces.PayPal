using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class AuctionInfoDto
    {
        /// <summary>
        /// The name of the auction site.
        /// </summary>
        [MaxLength(200)]
        [JsonPropertyName("auction_Site")]
        public string Site { get; set; }

        /// <summary>
        /// The auction site URL.
        /// </summary>
        [MaxLength(4000)]
        [JsonPropertyName("auction_item_site")]
        public string ItemSite { get; set; }

        /// <summary>
        /// The ID of the buyer who makes the purchase in the auction. This ID might be different from the payer ID provided for the payment.
        /// </summary>
        [MaxLength(500)]
        [JsonPropertyName("auction_buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// The date and time when the auction closes.
        /// </summary>
        [JsonPropertyName("auction_closing_date")]
        public DateTime ClosingDate { get; set; }
    }
}
