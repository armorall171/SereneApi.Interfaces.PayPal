using SereneApi.Interfaces.PayPal.API.Enums;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.Converters
{
    internal class ProtectionEligibilityJsonConverter: JsonConverter<ProtectionEligibility>
    {
        public override ProtectionEligibility Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() switch
            {
                "01" => ProtectionEligibility.Eligible,
                "02" => ProtectionEligibility.NotEligible,
                "03" => ProtectionEligibility.PartiallyEligible,
                _ => throw new ArgumentOutOfRangeException("")
            };
        }

        public override void Write(Utf8JsonWriter writer, ProtectionEligibility value, JsonSerializerOptions options)
        {
            switch(value)
            {
                case ProtectionEligibility.Eligible:
                writer.WriteStringValue("01");
                break;
                case ProtectionEligibility.NotEligible:
                writer.WriteStringValue("02");
                break;
                case ProtectionEligibility.PartiallyEligible:
                writer.WriteStringValue("03");
                break;
                default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
