using SereneApi.Interfaces.PayPal.API.Enums;

namespace SereneApi.Interfaces.PayPal.API.Payment
{
    public class SellerProtectionDto
    {
        /// <summary>
        /// Indicates whether the transaction is eligible for seller protection.
        /// For information, see <see href="https://www.paypal.com/us/webapps/mpp/security/seller-protection">PayPal Seller Protection for Merchants</see>.
        /// </summary>
        public ProtectionEligibility Status { get; internal set; }
    }
}
