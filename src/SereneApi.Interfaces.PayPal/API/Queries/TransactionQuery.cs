using SereneApi.Abstractions.Queries.Attributes;
using SereneApi.Interfaces.PayPal.API.Enums;
using SereneApi.Interfaces.PayPal.Converters;
using System;
using System.ComponentModel.DataAnnotations;

namespace SereneApi.Interfaces.PayPal.API.Queries
{
    public class TransactionQuery
    {
        /// <summary>
        /// Filters the transactions in the response by a PayPal transaction ID. A valid transaction ID is 17 characters long, except for an order ID, which is 19 characters long.
        /// </summary>
        [MinLength(17)]
        [MaxLength(19)]
        [QueryKey("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Filters the transactions in the response by a PayPal transaction event code. See <see href="https://developer.paypal.com/docs/integration/direct/transaction-search/transaction-event-codes/"> Transaction event codes</see>.
        /// </summary>
        [QueryKey("transaction_type")]
        public string TransactionType { get; set; }

        /// <summary>
        /// Filters the transactions in the response by the transaction status
        /// </summary>
        [QueryKey("transaction_status")]
        [QueryConverter(typeof(TransactionStatusQueryConverter))]
        public TransactionStatus Status { get; set; }

        /// <summary>
        /// Filters the transactions in the response by a gross transaction amount range.
        /// Specify the range as {start-range} TO {end-range}, where {start-range} is the lower limit of the gross PayPal transaction amount and {end-range} is the upper limit of the gross transaction amount.
        /// Specify the amounts in lower denominations. For example, to search for transactions from $5.00 to $10.05, specify [500 TO 1005].
        /// </summary>
        [QueryKey("transaction_amount")]
        public string TransactionAmount { get; set; }

        /// <summary>
        /// Filters the transactions in the response by a <see href="https://developer.paypal.com/docs/integration/direct/rest/currency-codes/">three-character ISO-4217 currency code</see> for the PayPal transaction currency.
        /// </summary>
        [QueryKey("transaction_currency")]
        public string TransactionCurrency { get; set; }

        [QueryKey("start_date")]
        [QueryConverter(typeof(Rfc3339QueryConverter))]
        [Required]
        public DateTime StartDate { get; set; }

        [QueryConverter(typeof(Rfc3339QueryConverter))]
        [QueryKey("end_date")]
        [Required]
        public DateTime EndDate { get; set; }
    }
}
