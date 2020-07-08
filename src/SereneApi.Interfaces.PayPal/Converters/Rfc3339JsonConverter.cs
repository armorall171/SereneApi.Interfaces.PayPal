using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.Converters
{
    internal class Rfc3339JsonConverter: JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();

            return DateTime.Parse(value);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            //"2020-06-20T00:00:00Z"
            string valueString = value.ToString("yyyy-MM-ddThh:mm:ssZ");

            writer.WriteStringValue(valueString);
        }
    }
}
