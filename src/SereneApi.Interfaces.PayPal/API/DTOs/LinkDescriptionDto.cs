using SereneApi.Abstractions.Request;
using SereneApi.Interfaces.PayPal.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.API.DTOs
{
    public class LinkDescriptionDto
    {
        /// <summary>
        /// The complete target URL. To make the related call, combine the method with this <see href="https://tools.ietf.org/html/rfc6570">URI Template-formatted</see> link.
        /// For pre-processing, include the $, (, and ) characters. The href is the key HATEOAS component that links a completed call with a subsequent call.
        /// </summary>
        [Required]
        [JsonPropertyName("href")]
        public string Link { get; set; }

        /// <summary>
        /// The <see href="https://tools.ietf.org/html/rfc5988#section-4">link relation type</see>, which serves as an ID for a link that unambiguously describes the semantics of the link.
        /// See <see href="https://www.iana.org/assignments/link-relations/link-relations.xhtml">Link Relations</see>.
        /// </summary>
        [Required]
        [JsonPropertyName("rel")]
        public string Relation { get; set; }

        /// <summary>
        /// The HTTP method required to make the related call.
        /// </summary>
        [JsonPropertyName("method")]
        [JsonConverter(typeof(MethodJsonConverter))]
        public Method Method { get; set; }
    }
}
