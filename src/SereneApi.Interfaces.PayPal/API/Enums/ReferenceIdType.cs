namespace SereneApi.Interfaces.PayPal.API.Enums
{
    /// <summary>
    /// The PayPal reference ID type.
    /// </summary>
    public enum ReferenceIdType
    {
        /// <summary>
        /// An order ID.
        /// </summary>
        Order,
        /// <summary>
        /// A transaction ID.
        /// </summary>
        Transaction,
        /// <summary>
        /// A subscription ID.
        /// </summary>
        Subscription,
        /// <summary>
        /// A pre-approved payment ID.
        /// </summary>
        PreApproved
    }
}
