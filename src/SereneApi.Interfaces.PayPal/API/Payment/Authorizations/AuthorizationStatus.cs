namespace SereneApi.Interfaces.PayPal.API.Payment.Authorizations
{
    /// <summary>
    /// The status for the authorized payment.
    /// </summary>
    public enum AuthorizationStatus
    {
        /// <summary>
        /// The authorized payment is created. No captured payments have been made for this authorized payment.
        /// </summary>
        Created,
        /// <summary>
        /// The authorized payment has one or more captures against it.
        /// The sum of these captured payments is greater than the amount of the original authorized payment.
        /// </summary>
        Captured,
        /// <summary>
        /// PayPal cannot authorize funds for this authorized payment.
        /// </summary>
        Denied,
        /// <summary>
        /// The authorized payment has expired.
        /// </summary>
        Expired,
        /// <summary>
        /// A captured payment was made for the authorized payment for an amount that is less than the amount of the original authorized payment.
        /// </summary>
        PartiallyCaptured,
        /// <summary>
        /// The authorized payment was voided. No more captured payments can be made against this authorized payment.
        /// </summary>
        Voided,
        /// <summary>
        /// The created authorization is in pending state. For more information, see <see cref="StatusDetailsDto"/>
        /// </summary>
        Pending
    }
}
