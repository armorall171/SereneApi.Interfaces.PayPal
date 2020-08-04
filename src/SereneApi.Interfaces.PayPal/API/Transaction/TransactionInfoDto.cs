using SereneApi.Interfaces.PayPal.API.DTOs;
using SereneApi.Interfaces.PayPal.API.Enums;
using SereneApi.Interfaces.PayPal.Converters;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.Transaction
{
    public class TransactionInfoDto
    {
        /// <summary>
        /// The ID of the PayPal account of the counterparty.
        /// </summary>
        [MaxLength(24)]
        [JsonPropertyName("paypal_account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// The PayPal-generated transaction ID.
        /// </summary>
        [MaxLength(24)]
        [JsonPropertyName("transaction_id")]
        public string Id { get; set; }

        /// <summary>
        /// The PayPal-generated base ID. PayPal exclusive. Cannot be altered. Defined as a related, pre-existing transaction or event.
        /// </summary>
        [MaxLength(24)]
        [JsonPropertyName("paypal_reference_id")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The PayPal reference ID type.
        /// </summary>
        [MinLength(3)]
        [MaxLength(3)]
        [JsonPropertyName("paypal_reference_id_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ReferenceIdType ReferenceType { get; set; }

        /// <summary>
        /// A five-digit transaction event code that classifies the transaction type based on money movement and debit or credit.
        /// See <see href="https://developer.paypal.com/docs/integration/direct/transaction-search/transaction-event-codes/">Transaction event codes</see>.
        /// </summary>
        [JsonPropertyName("transaction_event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// The date and time when work on a transaction began in the PayPal system, as expressed in the time zone of the account on this side of the payment.
        /// </summary>
        [MaxLength(25)]
        [JsonPropertyName("transaction_initiation_date")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime InitiationDate { get; set; }

        /// <summary>
        /// The date and time when the transaction was last changed, as expressed in the time zone of the account on this side of the payment.
        /// </summary>
        [MaxLength(25)]
        [JsonPropertyName("transaction_updated_date")]
        [JsonConverter(typeof(Rfc3339JsonConverter))]
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// The all-inclusive gross transaction amount that was transferred between the sender and receiver through PayPal.
        /// </summary>
        [JsonPropertyName("transaction_amount")]
        public MoneyDto TransactionAmount { get; set; }

        /// <summary>
        /// The PayPal fee amount. All transaction fees are included in this amount, which is the record of fee associated with the transaction.
        /// </summary>
        [JsonPropertyName("fee_amount")]
        public MoneyDto FeeAmount { get; set; }

        /// <summary>
        /// The reduction in price offered for goods or services purchased.
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public MoneyDto DiscountAmount { get; set; }

        /// <summary>
        /// An insurance charge. Guarantees the quality or delivery of a product.
        /// </summary>
        [JsonPropertyName("insurance_amount")]
        public MoneyDto InsuranceAmount { get; set; }

        /// <summary>
        /// The PayPal- or merchant-reported sales tax amount for the transaction.
        /// </summary>
        [JsonPropertyName("sales_tax_amount")]
        public MoneyDto SalesTaxAmount { get; set; }

        /// <summary>
        /// The PayPal- or merchant-reported shipping amount for the transaction.
        /// </summary>
        [JsonPropertyName("shipping_amount")]
        public MoneyDto ShippingAmount { get; set; }

        /// <summary>
        /// The discount on the shipping amount.
        /// </summary>
        [JsonPropertyName("shipping_discount_amount")]
        public MoneyDto ShippingDiscountAmount { get; set; }

        /// <summary>
        /// The special amount that is added to the transaction.
        /// </summary>
        [JsonPropertyName("other_amount")]
        public MoneyDto OtherAmount { get; set; }

        /// <summary>
        /// The tip.
        /// </summary>
        [JsonPropertyName("tip_amount")]
        public MoneyDto TipAmount { get; set; }

        /// <summary>
        /// A code that indicates the transaction status.
        /// </summary>
        [JsonPropertyName("transaction_status")]
        [JsonConverter(typeof(TransactionStatusJsonConverter))]
        public TransactionStatus Status { get; set; }

        /// <summary>
        /// The subject of payment. The payer passes this value to the payee. The payer controls this data through the interface through which he or she sends the data.
        /// </summary>
        [MaxLength(256)]
        [JsonPropertyName("transaction_subject")]
        public string Subject { get; set; }

        /// <summary>
        /// A special note that the payer passes to the payee. Might contain special customer requests, such as shipping instructions.
        /// </summary>
        [MaxLength(4000)]
        [JsonPropertyName("transaction_note")]
        public string Note { get; set; }

        /// <summary>
        /// The payment tracking ID, which is a unique ID that partners specify to either get information about a payment or request a refund.
        /// </summary>
        [MaxLength(127)]
        [JsonPropertyName("payment_tracking_id")]
        public string PaymentTrackingId { get; set; }

        /// <summary>
        /// The bank reference ID. The bank provides this value for an ACH transaction.
        /// </summary>
        [MinLength(127)]
        [JsonPropertyName("bank_reference_id")]
        public string BankReferenceId { get; set; }

        /// <summary>
        /// The ending balance.
        /// </summary>
        [JsonPropertyName("ending_balance")]
        public MoneyDto EndingBalance { get; set; }

        /// <summary>
        /// The available amount of transaction currency during the completion of this transaction.
        /// </summary>
        [JsonPropertyName("available_balance")]
        public MoneyDto AvailableBalance { get; set; }

        /// <summary>
        /// The invoice ID that is sent by the merchant with the transaction.
        /// </summary>
        [MaxLength(127)]
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// The merchant-provided custom text.
        /// </summary>
        [MaxLength(127)]
        [JsonPropertyName("custom_field")]
        public string CustomField { get; set; }

        /// <summary>
        /// Indicates whether the transaction is eligible for protection.
        /// </summary>
        [JsonPropertyName("protection_eligibility")]
        [JsonConverter(typeof(ProtectionEligibilityJsonConverter))]
        public ProtectionEligibility ProtectionEligibility { get; set; }

        /// <summary>
        /// The credit term. The time span covered by the installment payments as expressed in the term length plus the length time unit code.
        /// </summary>
        [MaxLength(25)]
        [JsonPropertyName("credit_term")]
        public string CreditTerm { get; set; }

        /// <summary>
        /// The overall amount of the credit transaction fee.
        /// </summary>
        [JsonPropertyName("credit_transaction_fee")]
        public MoneyDto CreditTransactionFee { get; set; }

        /// <summary>
        /// The overall amount of the credit promotional fee.
        /// </summary>
        [JsonPropertyName("credit_promotional_fee")]
        public MoneyDto CreditPromotionalFee { get; set; }

        /// <summary>
        /// The payment method that was used for a transaction.
        /// </summary>
        [JsonPropertyName("payment_method_type")]
        public PaymentMethodType PaymentMethod { get; set; }
    }
}
