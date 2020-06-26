namespace SereneApi.Interfaces.PayPal.API.Enums
{
    public enum TransactionStatus
    {
        /// <summary>
        /// D - PayPal or merchant rules denied the transaction.
        /// </summary>
        Denied = 'D',
        /// <summary>
        /// F - The original recipient partially refunded the transaction.
        /// </summary>
        PartialRefund = 'F',
        /// <summary>
        /// P - The transaction is pending. The transaction was created but waits for another payment process to complete, such as an ACH transaction, before the status changes to (S)uccessful.
        /// </summary>
        Pending = 'P',
        /// <summary>
        /// S - The transaction successfully completed without a denial and after any pending statuses.
        /// </summary>
        Successful = 'S',
        /// <summary>
        /// V - A successful transaction was reversed and funds were refunded to the original sender.
        /// </summary>
        Refunded = 'V'
    }
}
