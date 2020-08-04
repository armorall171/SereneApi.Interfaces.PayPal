using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SereneApi.Interfaces.PayPal.API.DTOs;

namespace SereneApi.Interfaces.PayPal.API.Payment.Authorizations
{
    public class AuthorizationDto
    {
        /// <summary>
        /// [Read-Only] The status for the authorized payment.
        /// </summary>
        [JsonPropertyName("status")]
        public AuthorizationStatus Status { get; internal set; }

        /// <summary>
        /// [Read-Only] The details of the authorized order pending status.
        /// </summary>
        [JsonPropertyName("status_details")]
        public AuthorizationStatusDetailsDto StatusDetails { get; internal set; }

        /// <summary>
        /// [Read-Only] The PayPal-generated ID for the authorized payment.
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; internal set; }

        /// <summary>
        /// [Read-Only] The amount for this authorized payment.
        /// </summary>
        [JsonPropertyName("amount")]
        public MoneyDto Amount { get; internal set; }

        /// <summary>
        /// [Read-Only] The API caller-provided external ID.
        /// Used to reconcile API caller-initiated transactions with PayPal transactions.
        /// Appears in transaction and settlement reports.
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; internal set; }

        /// <summary>
        /// The API caller-provided external ID.
        /// Used to reconcile API caller-initiated transactions with PayPal transactions.
        /// Appears in transaction and settlement reports.
        /// </summary>
        [JsonPropertyName("custom_id")]
        [MaxLength(127)]
        public string CustomId { get; set; }

        /// <summary>
        /// The level of protection offered as defined by <see href="https://www.paypal.com/us/webapps/mpp/security/seller-protection">PayPal Seller Protection for Merchants</see>.
        /// </summary>
        [JsonPropertyName("seller_protection")]
        public SellerProtectionDto SellerProtection { get; set; }

        /// <summary>
        /// The date and time when the authorized payment expires.
        /// </summary>
        [JsonPropertyName("expiration_time")]
        [MinLength(20)]
        [MaxLength(64)]
        public DateTime ExpirationTime { get; set; }
    }
}
