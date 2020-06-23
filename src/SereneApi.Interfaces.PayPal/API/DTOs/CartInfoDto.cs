using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class CartInfoDto
    {
        /// <summary>
        /// An array of item details.
        /// </summary>
        [JsonPropertyName("item_details")]
        public List<ItemDetailsDto> ItemDetails { get; set; }

        /// <summary>
        /// Indicates whether the item amount or the shipping amount already includes tax.
        /// </summary>
        [JsonPropertyName("tax_inclusive")]
        public bool TaxInclusive { get; set; }

        /// <summary>
        /// The ID of the invoice. Appears for only PayPal-generated invoices.
        /// </summary>
        [JsonPropertyName("paypal_invoice_id")]
        public string InvoiceId { get; set; }
    }
}
