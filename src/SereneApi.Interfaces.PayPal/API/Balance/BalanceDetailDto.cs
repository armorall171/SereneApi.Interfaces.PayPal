using SereneApi.Interfaces.PayPal.API.DTOs;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.Balance
{
    public class BalanceDetailDto
    {
        /// <summary>
        /// Currency Code of the balances listed.
        /// </summary>
        [JsonPropertyName("currency")]
        [MinLength(3)]
        [MaxLength(3)]
        public string Currency { get; set; }

        /// <summary>
        /// Optional field representing if the currency is primary currency or not.
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// The total amount in PayPal account. It is the sum of all the other balances.
        /// </summary>
        [Required]
        [JsonPropertyName("total_balance")]
        public MoneyDto Total { get; set; }

        /// <summary>
        /// The amount of cash in an Account which is at the customer's disposal.
        /// This amount is captured at settlement cutoff time in the user's time zone as defined for the user.
        /// </summary>
        [JsonPropertyName("available_balance")]
        public MoneyDto Available { get; set; }

        /// <summary>
        /// Balance withheld in the account.
        /// The portion of funds that PayPal holds for the customer that is not currently at the customer's disposal.
        /// </summary>
        [JsonPropertyName("withheld_balance")]
        public MoneyDto Withheld { get; set; }
    }
}
