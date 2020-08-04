using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.Payment.Authorizations
{
    public class AuthorizationStatusDetailsDto
    {
        /// <summary>
        /// The reason why the authorized <see cref="AuthorizationStatus"/> is Pending. 
        /// </summary>
        [JsonPropertyName("reason")]
        public AuthorizationStatusReason Reason { get; internal set; }
    }
}
