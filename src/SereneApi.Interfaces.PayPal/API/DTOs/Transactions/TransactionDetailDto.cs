using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs.Transactions
{
    public class TransactionDetailDto
    {
        /// <summary>
        /// The transaction information.
        /// </summary>
        [JsonPropertyName("transaction_info")]
        public TransactionInfoDto TransactionInfo { get; set; }

        /// <summary>
        /// The payer information.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInfoDto PayerInfo { get; set; }

        /// <summary>
        /// The shipping information.
        /// </summary>
        [JsonPropertyName("shipping_info")]
        public ShippingInfoDto ShippingInfo { get; set; }

        /// <summary>
        /// The cart information.
        /// </summary>
        [JsonPropertyName("cart_info")]
        public CartInfoDto CartInfo { get; set; }

        /// <summary>
        /// The store information.
        /// </summary>
        [JsonPropertyName("store_info")]
        public StoreInfoDto StoreInfo { get; set; }

        /// <summary>
        /// The auction information.
        /// </summary>
        [JsonPropertyName("auction_info")]
        public AuctionInfoDto AuctionInfo { get; set; }

        /// <summary>
        /// The incentive information.
        /// </summary>
        [JsonPropertyName("incentive_info")]
        public IncentiveInfoDto IncentiveInfo { get; set; }
    }
}
