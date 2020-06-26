using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class ItemDetailsDto
    {
        /// <summary>
        /// An item code that identifies a merchant's goods or service.
        /// </summary>
        [MaxLength(1000)]
        [JsonPropertyName("item_code")]
        public string Code { get; set; }

        /// <summary>
        /// The item name.
        /// </summary>
        [MaxLength(200)]
        [JsonPropertyName("item_name")]
        public string Name { get; set; }

        /// <summary>
        /// The item description.
        /// </summary>
        [MaxLength(2000)]
        [JsonPropertyName("item_description")]
        public string Description { get; set; }

        /// <summary>
        /// The item options. Describes option choices on the purchase of the item in some detail.
        /// </summary>
        [MaxLength(4000)]
        [JsonPropertyName("item_options")]
        public string Options { get; set; }

        /// <summary>
        /// The number of purchased units of goods or a service.
        /// </summary>
        [MaxLength(4000)]
        [JsonPropertyName("item_quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// The cost for each instance of goods or a service.
        /// </summary>
        [JsonPropertyName("item_unit_price")]
        public MoneyDto UnitPrice { get; set; }

        /// <summary>
        /// The amount of the payment for the item.
        /// </summary>
        [JsonPropertyName("item_amount")]
        public MoneyDto Amount { get; set; }

        /// <summary>
        /// The reduction in price associated with goods or a service.
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public MoneyDto DiscountAmount { get; set; }

        /// <summary>
        /// An increment or decrement to a purchase amount.
        /// </summary>
        [JsonPropertyName("adjustment_amount")]
        public MoneyDto AdjustmentAmount { get; set; }

        /// <summary>
        /// The amount of money charged for gift wrapping an item.
        /// </summary>
        [JsonPropertyName("gift_wrap_amount")]
        public MoneyDto GiftWrapAmount { get; set; }

        /// <summary>
        /// A rate, expressed in hundreds, that is used to calculate a levy for the purchase of goods or services.
        /// </summary>
        [MaxLength(10)]
        [JsonPropertyName("tax_percentage")]
        public string TaxPercentage { get; set; }

        /// <summary>
        /// An array of tax amounts levied by a government on the purchase of goods or services.
        /// </summary>
        [JsonPropertyName("tax_amounts")]
        public List<ItemDetailTaxAmountDto> TaxAmounts { get; set; }

        /// <summary>
        /// The delivery cost.
        /// </summary>
        [JsonPropertyName("basic_shipping_amount")]
        public MoneyDto BasicShippingAmount { get; set; }

        /// <summary>
        /// The cost for expedited delivery of the goods.
        /// </summary>
        [JsonPropertyName("extra_shipping_amount")]
        public MoneyDto ExtraShippingAmount { get; set; }

        /// <summary>
        /// A charge for processing the purchase of goods or services.
        /// </summary>
        [JsonPropertyName("handling_amount")]
        public MoneyDto HandlingAmount { get; set; }

        /// <summary>
        /// A charge for guaranteeing the quality of a product or delivery of a product.
        /// </summary>
        [JsonPropertyName("insurance_amount")]
        public MoneyDto InsuranceAmount { get; set; }

        /// <summary>
        /// The sum of all factors, item cost, discounts, tax, shipping, and so on, that goes into the cost of an item.
        /// </summary>
        [JsonPropertyName("total_item_amount")]
        public MoneyDto TotalItemAmount { get; set; }

        /// <summary>
        /// The invoice number. An alphanumeric string that identifies a billing for a merchant.
        /// </summary>
        [MaxLength(200)]
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// An array of checkout options. Each option has a name and value.
        /// </summary>
        [JsonPropertyName("checkout_options")]
        public List<CheckoutOptionDto> CheckoutOptions { get; set; }
    }
}
